; example1.nsi
;
; This script is perhaps one of the simplest NSIs you can make. All of the
; optional settings are left to their default settings. The installer simply 
; prompts the user asking them where to install, and drops a copy of example1.nsi
; there. 

;--------------------------------

!define APP "PDFToCmyk"
!system 'DefineAsmVer.exe "bin\DEBUG\${APP}.exe" "!define VER ""[SVER]"" " > Tmpver.nsh'
!include "Tmpver.nsh"
!searchreplace APV ${VER} "." "_"

; The name of the installer
Name "${APP}"

; The file to write
OutFile "Setup_${APP}_${APV}.exe"

; The default installation directory
InstallDir "$APPDATA\PDFToCmyk"

; Request application privileges for Windows Vista
RequestExecutionLevel user

;--------------------------------

; Pages

Page directory
Page instfiles

;--------------------------------

; The stuff to install
Section "" ;No components page, name is not important

  ; Set output path to the installation directory.
  SetOutPath $INSTDIR
  
  ; Put file there
  File /r /x "*.vshost.*" "bin\DEBUG\*.*"
  
  CreateShortCut "$DESKTOP\${APP}.lnk" "$INSTDIR\${APP}.exe"
  
SectionEnd ; end the section
