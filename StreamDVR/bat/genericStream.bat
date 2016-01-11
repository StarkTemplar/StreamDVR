setlocal ENABLEDELAYEDEXPANSION

REM read settings from ini file
REM %0 is the script file name (with path), %~0 removes the surrounding " " ("%~0" == %0)
REM Adding dp returns the drive and path to the file, instead of the file name itself
REM found ini file reading from http://almanachackers.com/blog/2009/12/31/reading-an-ini-config-file-from-a-batch-file/
set INIFILE="%~dp0\StreamDVR.ini"
call:getvalue %INIFILE% "livestreamerEXE" "" livestreamerEXE
call:getvalue %INIFILE% "handbrakeEXE" "" handbrakeEXE
call:getvalue %INIFILE% "mediaplayerEXE" "" mediaplayerEXE
call:getvalue %INIFILE% "logDir" "" logDir
call:getvalue %INIFILE% "outputDir" "" outputDir
call:getvalue %INIFILE% "handbrakeoutputDir" "" handbrakeoutputDir
call:getvalue %INIFILE% "quality" "" quality
call:getvalue %INIFILE% "handbrakePreset" "" handbrakePreset

REM gather cmd line options
set stream=%~1
set filenameinput=%~2
set transcode=%~3
set watch=%~4


REM set livestreamer options
set livestreamerOptions=-l debug -e --player-continuous-http --retry-streams 120 --retry-open 6

REM set date
set mydate=%DATE%
set mydate=%mydate:~-10%
set mydate=%mydate:/=-%
set mytime=%TIME:~0,8%
set mytime=%mytime::=%
set mydate=%mydate%_%mytime%

REM set retry parameters
set pingTimeout=300000
set retryNumber=3

REM set stream quality preferences. always include worst or best
REM set quality="high,best"

REM set handbrake preset name
REM set handbrakePreset="AppleTV 3"

REM executable locations
REM set livestreamerEXE="C:\Program Files (x86)\Livestreamer\livestreamer.exe"
REM set handbrakeEXE="c:\program files\handbrake\handbrakecli.exe"
REM set mediaplayerEXE="C:\Program Files\VideoLAN\VLC\vlc.exe"

set openVideoBat="%~dp0openVideo.bat"

REM output directories
REM set logDir=%APPDATA%\StreamDVR\
REM set outputDir=D:\needsconverted\
REM set handbrakeoutputDir=D:\Starcraft\

REM create log directory
mkdir %logDir%


REM loop that runs X times to try and capture stream. This is to handle when streams go offline and then back online
for /L %%n in (1,1,%retryNumber%) do (
	set origFile="%outputDir%%mydate%_%filenameinput%_%%n.mp4"
	set editedFile="%handbrakeoutputDir%%mydate%_%filenameinput%_edited_%%n.mp4"
	
	REM open video player after 15 seconds if watching parameter was sent
	IF /I %watch% EQU Y (start cmd /k Call %openVideoBat% "%mediaplayerEXE%" !origFile!)

	REM capture stream with retry params
	"%livestreamerEXE%" !livestreamerOptions! -o !origFile! %stream% %quality% >> "%logDir%livestreamer_%mydate%_%filenameinput%.log"

	REM wait pingTimeout amount of time before trying stream again
	ping 192.0.2.2 -n 1 -w %pingTimeout% > nul

	set livestreamerOptions=-l debug -e --player-continuous-http
)

REM transcode videos using handbrake if transcode parameter was sent
IF /I %transcode% EQU Y (
	for /L %%n in (1,1,3) do (
		"%handbrakeEXE%" -i "%outputDir%%mydate%_%filenameinput%_%%n.mp4" -o "%handbrakeoutputDir%%mydate%_%filenameinput%_edited_%%n.mp4" --preset=%handbrakePreset%
	)
)
goto:eof

:getvalue
rem This function reads a value from an INI file and stored it in a variable
rem %1 = name of ini file to search in.
rem %2 = search term to look for
rem %3 = group name (not currently used)
rem %4 = variable to place search result
FOR /F "eol=; eol=[ tokens=1,2* delims==" %%i in ('findstr /b /l /i %~2= %1') DO set %~4=%%~j
goto:eof