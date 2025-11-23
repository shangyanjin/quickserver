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
Name: "{app}\nginx\logs\"
Name: "{app}\pgsql\data\"
Name: "{app}\pgsql\logs\"
Name: "{app}\redis\data\"
Name: "{app}\redis\logs\"

[Files]
Source: contrib\*; DestDir: {app}\contrib; Flags: ignoreversion recursesubdirs createallsubdirs

Source: docs\*; DestDir: {app}\docs; Flags: ignoreversion recursesubdirs createallsubdirs

Source: mariadb\bin\*; DestDir: {app}\mariadb\bin; Flags: ignoreversion
Source: mariadb\include\*; DestDir: {app}\mariadb\include; Flags: ignoreversion recursesubdirs createallsubdirs
Source: mariadb\lib\*; DestDir: {app}\mariadb\lib; Flags: ignoreversion recursesubdirs createallsubdirs
Source: mariadb\share\*; DestDir: {app}\mariadb\share; Flags: ignoreversion recursesubdirs createallsubdirs

Source: nginx\conf\*; Excludes: "key.pem,cert.pem,.gitignore"; DestDir: {app}\nginx\conf; Flags: ignoreversion recursesubdirs createallsubdirs
Source: nginx\temp\*; DestDir: {app}\nginx\temp; Flags: ignoreversion recursesubdirs createallsubdirs
Source: nginx\www\phpmyadmin\*; Excludes: ".gitignore"; DestDir: {app}\nginx\www\phpmyadmin; Flags: ignoreversion recursesubdirs createallsubdirs
Source: nginx\www\index.php; DestDir: {app}\nginx\www; Flags: ignoreversion onlyifdoesntexist
Source: nginx\nginx.exe; DestDir: {app}\nginx; Flags: ignoreversion

Source: php\*; Excludes: ".gitignore"; DestDir: {app}\php; Flags: ignoreversion recursesubdirs createallsubdirs

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