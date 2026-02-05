---
layout: post
title: "Ubuntu beim Windows-Start automatisch starten"
slug: "ubuntu-windows-start"
date: 2025-03-15 14:53:13 +0100
categories: [automatisierung, iot, open-source, softwareentwicklung, wsl]
description: "Wenn du häufig mit Ubuntu unter Windows Subsystem for Linux (WSL) arbeitest, kann es praktisch sein, die Linux-Distribution automatisch mit dem Start von Wind..."
tags: [autostart-ubuntu, entwicklung, linux-auf-windows, linux-befehle, linux-integration, powershell, shellstartup, software-entwicklung, ubuntu-2404, ubuntu-automatisch-starten, ubuntu-distribution, ubuntu-im-hintergrund-starten, windows-subsystem-for-linux, windows-automatisierung, wsl, wsl---set-default, wsl-2]
author: 
  name: "Christian Storb" 
  url: "/author/christian-storb/"
image: /assets/images/consulting/blog/ubuntu-und-wsl.jpg
locale: "de_DE"
seo:
  type: BlogPosting
redirect_from:
  - /Automatisierung/IoT/Linux/Open Source/Softwareentwicklung/Technologie/Windows/WSL (Windows Subsystem for Linux)/2025/03/15/ubuntu-beim-start-von-windows-automatisch-starten-ein-leitfaden.html
---
Wenn du häufig mit Ubuntu unter Windows Subsystem for Linux (WSL) arbeitest, kann es praktisch sein, die Linux-Distribution automatisch mit dem Start von Windows zu laden. Durch das automatische Starten sparst du Zeit und kannst direkt nach dem Hochfahren deines PCs in deiner bevorzugten Arbeitsumgebung loslegen. Dieser Artikel konzentriert sich auf praktische Beispiele mit minimaler Erläuterung, um dir eine klare und einfache Anleitung zu bieten.

### Schritt 1: Standard-Distribution auf Ubuntu setzen

Bevor Ubuntu automatisch gestartet werden kann, solltest du sicherstellen, dass es als Standard-Distribution eingerichtet ist.

- Öffne die **PowerShell** oder die Eingabeaufforderung.

- Führe folgenden Befehl aus:<br>`wsl --set-default Ubuntu-24.04`<br>Dadurch wird garantiert, dass Ubuntu die Standard-Distribution ist, die gestartet wird.

### Schritt 2: Eine Verknüpfung für den Autostart erstellen

Um Ubuntu beim Start von Windows auszuführen, kannst du eine Verknüpfung im Autostart-Ordner erstellen.

- Drücke `Win + R`, um den **Ausführen-Dialog** zu öffnen.

- Gib `shell:startup` ein und klicke auf **OK**. Dies öffnet den Autostart-Ordner.

- Erstelle eine Verknüpfung:

- Rechtsklick im Ordner → **Neu** → **Verknüpfung**.

- Gib den folgenden Befehl ein:<br>`wsl -d Ubuntu-24.04`

- Klicke auf **Weiter** und gib der Verknüpfung einen Namen, z. B. „Ubuntu starten“.

- Speichere die Verknüpfung.

### Schritt 3: Testen

Starte deinen Computer neu und überprüfe, ob Ubuntu automatisch startet. Wenn alles korrekt eingerichtet ist, sollte beim Hochfahren ein WSL-Fenster mit deiner Ubuntu-Distribution erscheinen.

### Optional: Verdecktes Starten einrichten

Falls dich das sichtbare Startfenster stört, kannst du ein Skript erstellen, das Ubuntu im Hintergrund startet:

- Erstelle ein PowerShell-Skript mit folgendem Inhalt:<br>`Start-Process wsl -ArgumentList "-d Ubuntu-24.04" -WindowStyle Hidden`

- Speichere dieses Skript und erstelle eine Verknüpfung im Autostart-Ordner, die dieses Skript aufruft.

### Fazit

Mit diesen einfachen Schritten startet Ubuntu automatisch mit Windows, sodass du direkt nach dem Hochfahren loslegen kannst. Diese Lösung ist besonders effizient, wenn du WSL und Ubuntu regelmäßig nutzt. Probiere es aus und genieße den nahtlosen Start!

### Referenzen

- [Ubuntu 24.04 auf WSL unter Windows installieren: Ein Leitfaden](https://storbconsulting.wordpress.com/2025/03/15/ubuntu-24-04-auf-wsl-unter-windows-installieren-ein-leitfaden/)
