setlocal ENABLEDELAYEDEXPANSION

REM gather cmd line options
set stream=%~1
set filenameinput=%~2
set watch=%~3

REM set livestreamer options
set livestreamerOptions=-l debug -e --player-continuous-http --retry-streams 120 --retry-open 6

REM set date
set mydate=%DATE%
set mydate=%mydate:~-10%
set mydate=%mydate:/=-%

REM set retry parameters
set pingTimeout=300000
set retryNumber=3

REM set stream quality preferences. always include worst or best
set quality="high,best"

REM set handbrake preset name
set handbrakePreset="AppleTV 3"

REM executable locations
set livestreamerEXE="C:\Program Files (x86)\Livestreamer\livestreamer.exe"
set handbrakeEXE="c:\program files\handbrake\handbrakecli.exe"
set mediaplayerEXE="C:\Program Files\VideoLAN\VLC\vlc.exe"
set openVideoBat="%~dp0openVideo.bat"

REM output directories
set logDir=%APPDATA%\StreamDVR\
set outputDir=D:\needsconverted\
set handbrakeoutputDir=D:\Starcraft\

REM create log directory
mkdir %logDir%


REM loop that runs X times to try and capture stream. This is to handle when streams go offline and then back online
for /L %%n in (1,1,%retryNumber%) do (
	set origFile="%outputDir%%mydate%_%filenameinput%_%%n.mp4"
	set editedFile="%handbrakeoutputDir%%mydate%_%filenameinput%_edited_%%n.mp4"
	
	REM open video player after 15 seconds if watching parameter was sent
	IF /I %watch% EQU Y (start cmd /k Call %openVideoBat% %mediaplayerEXE% !origFile!)

	REM capture stream with retry params
	%livestreamerEXE% !livestreamerOptions! -o !origFile! %stream% %quality% >> "%logDir%livestreamer_%mydate%_%filenameinput%.log"

	REM wait pingTimeout amount of time before trying stream again
	ping 192.0.2.2 -n 1 -w %pingTimeout% > nul

	set livestreamerOptions=-l debug -e --player-continuous-http
)

REM transcode videos using handbrake
for /L %%n in (1,1,3) do (
	%handbrakeEXE% -i "%outputDir%%mydate%_%filenameinput%_%%n.mp4" -o "%handbrakeoutputDir%%mydate%_%filenameinput%_edited_%%n.mp4" --preset=%handbrakePreset%
)