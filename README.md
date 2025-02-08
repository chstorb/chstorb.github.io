BlazorWebAssemblyApp
---
Dieses Projekt ist die Basis für die Blazor WebAssembly Anwendung, die als GitHub-Page unter 
https://chstorb.github.io erreichbar ist. 

# Veröffentlichung auf GitHub
1. In dem Verzeichnis D:\chstorb\chstorb.github.io mit dem Windows Explorer alles bis auf das Unterverzeichnis .git löschen. 
2. Das Veröffentlichungsprofil "FolderProfile.pubxml" in Visual Studio ausführen. Dieses Profil ist so konfiguriert, dass es keine Dateien im Zeileverzeichnis löscht (Konflikt mit .git)
3. Nachdem die Dateien in das Verzeichnis D:\chstorb\chstorb.github.io kopiert wurden, indem Ordner alles bis auf die Unterordner .git und wwwroot löschen.
4. Den Inhalt des Vereichnisses wwwroot eine Ebene höher verschieben und den wwwroot Ordner löschen.
5. Die Änderungen mit Visual Studio Code committen und pushen.
