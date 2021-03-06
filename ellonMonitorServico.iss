; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Ellon Monitor Servi�os"   
#define MyAppVersion GetFileVersion('F:\Projetos\MonitordeServicos\Install\release\MonitordeServicos.exe') 
#define MyAppPublisher "Ellon Tecnologia em gest�o "
#define MyAppURL "http://www.somosellon.com.br/"
#define MyAppExeName "MonitordeServicos.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{5DE5FBE2-0AE5-4395-B92C-06305DBB38E1}
AppName={#MyAppName} {#MyAppVersion}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName=C:\EllonSistemas\EllonMonitorServicos
DisableProgramGroupPage=yes
OutputDir=F:\Projetos\MonitordeServicos
OutputBaseFilename=Ellon Monitor Servicos {#MyAppVersion}
SetupIconFile=F:\Imagens projeto\ellonIcone.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "brazilianportuguese"; MessagesFile: "compiler:Languages\BrazilianPortuguese.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "F:\Projetos\MonitordeServicos\Install\release\MonitordeServicos.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\Projetos\MonitordeServicos\Install\release\ServicoMonitor.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\Projetos\MonitordeServicos\Install\release\Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion

; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{commonprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent



