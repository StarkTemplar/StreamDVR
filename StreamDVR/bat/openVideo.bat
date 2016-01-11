REM gather cmd line options
set mediaplayerEXE=%~1
set filenameinput=%~2

REM wait 15 seconds
ping 192.0.2.2 -n 1 -w 30000 > nul
"%mediaplayerEXE%" "%filenameinput%"
exit