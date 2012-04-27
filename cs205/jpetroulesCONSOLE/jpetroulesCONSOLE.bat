@echo off
set NAME=jpetroulesCONSOLE

color 4f
echo Make sure you are running this program from the Visual Studio Command Prompt! (press [Enter] to continue)
set /p DUMMY=%=%
color

set INPUT=
set /p INPUT=Which program would you like to compile? (enter CS or VB): %=%
if /i "%INPUT%" == "CS" (
goto cs
)
if /i "%INPUT%" == "VB" (
goto vb
) else (
goto end
)

:cs
if exist "%CD%\%NAME%.cs.exe" del "%CD%\%NAME%.cs.exe"
csc /out:%NAME%.cs.exe %NAME%.cs
%NAME%.cs.exe
goto :end

:vb
if exist "%CD%\%NAME%.vb.exe" del "%CD%\%NAME%.vb.exe"
vbc /out:%NAME%.vb.exe %NAME%.vb
%NAME%.vb.exe
goto :end

:end
