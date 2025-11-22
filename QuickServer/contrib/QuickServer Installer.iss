; QuickServer iss
#define MyAppName "QuickServer"
#define MyAppVersion "1.0.0"
#define MyAppPublisher "QuickServer"
#define MyAppURL "https://github.com/quickserver/quickserver"
#define MyAppExeName "QuickServer.exe"
#define Year "2025"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{44CF85C5-C9D2-435F-941B-75597AA9A6FB}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
WizardStyle=modern
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={sd}\{#MyAppName}
SourceDir=..\
DefaultGroupName={#MyAppName}
VersionInfoDescription=QuickServer (version {#MyAppVersion})
VersionInfoCopyright=Copyright 2025 QuickServer
VersionInfoCompany=QuickServer
LicenseFile=..\LICENSE
InfoBeforeFile=
OutputDir=../out
OutputBaseFilename=QuickServer-{#MyAppVersion}
SetupIconFile=../src/QuickServer/logo.ico
Compression=lzma2/normal
LZMANumBlockThreads=4
LZMAUseSeparateProcess=yes
SolidCompression=false
RestartIfNeededByRun=false
PrivilegesRequired=admin
DirExistsWarning=no

[Languages]
Name: english; MessagesFile: compiler:Default.isl

[Tasks]
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: unchecked

[Dirs]
Name: "{app}\nginx\default\logs\"
Name: "{app}\pgsql\data\"
Name: "{app}\pgsql\logs\"
Name: "{app}\redis\data\"
Name: "{app}\redis\logs\"

[Files]
Source: contrib\*; DestDir: {app}\contrib; Flags: ignoreversion recursesubdirs createallsubdirs

Source: docs\*; DestDir: {app}\docs; Flags: ignoreversion recursesubdirs createallsubdirs

Source: mariadb\default\bin\*; DestDir: {app}\mariadb\default\bin; Flags: ignoreversion
Source: mariadb\default\include\*; DestDir: {app}\mariadb\default\include; Flags: ignoreversion recursesubdirs createallsubdirs
Source: mariadb\default\lib\*; DestDir: {app}\mariadb\default\lib; Flags: ignoreversion recursesubdirs createallsubdirs
Source: mariadb\default\share\*; DestDir: {app}\mariadb\default\share; Flags: ignoreversion recursesubdirs createallsubdirs

Source: nginx\default\conf\*; Excludes: "key.pem,cert.pem,.gitignore"; DestDir: {app}\nginx\default\conf; Flags: ignoreversion recursesubdirs createallsubdirs
Source: nginx\default\temp\*; DestDir: {app}\nginx\default\temp; Flags: ignoreversion recursesubdirs createallsubdirs
Source: nginx\default\www\phpmyadmin\*; Excludes: ".gitignore"; DestDir: {app}\nginx\default\www\phpmyadmin; Flags: ignoreversion recursesubdirs createallsubdirs
Source: nginx\default\www\index.php; DestDir: {app}\nginx\default\www; Flags: ignoreversion onlyifdoesntexist
Source: nginx\default\nginx.exe; DestDir: {app}\nginx\default; Flags: ignoreversion

Source: php\default\*; Excludes: ".gitignore"; DestDir: {app}\php\default; Flags: ignoreversion recursesubdirs createallsubdirs

Source: pgsql\*; Excludes: ".gitignore,data"; DestDir: {app}\pgsql; Flags: ignoreversion recursesubdirs createallsubdirs

Source: redis\*; Excludes: ".gitignore,data,logs"; DestDir: {app}\redis; Flags: ignoreversion recursesubdirs createallsubdirs

Source: readme.txt; DestDir: {app}; Flags: ignoreversion
Source: "VC_redist.x64.exe"; DestDir: {tmp}; Flags: ignoreversion deleteafterinstall
Source: QuickServer.exe; DestDir: {app}; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: {group}\{#MyAppName}; Filename: {app}\{#MyAppExeName}
Name: {group}\{cm:UninstallProgram,{#MyAppName}}; Filename: {uninstallexe}
Name: {commondesktop}\{#MyAppName}; Filename: {app}\{#MyAppExeName}; Tasks: desktopicon

[Run]
Filename: {app}\{#MyAppExeName}; Description: {cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}; Flags: nowait postinstall shellexec
Filename: "{tmp}\VC_redist.x64.exe"; Parameters: "/install /passive /norestart"
;Filename: iexplore.exe; Parameters: "https://github.com/quickserver/quickserver"; Verb: open; Flags: shellexec runasoriginaluser