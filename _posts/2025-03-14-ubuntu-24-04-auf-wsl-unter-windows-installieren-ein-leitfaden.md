---
layout: post
title: "Ubuntu 24.04 auf WSL unter Windows installieren: Ein Leitfaden"
date: 2025-03-14 14:33:43 +0100
categories: [.NET, IoT, Linux, Open Source, Programmierung, Softwareentwicklung, Tech Tips, Technologie, Windows]
description: "Die Kombination von Windows und Linux in einem System bietet unschätzbare Flexibilität. Mit Windows Subsystem for Linux (WSL) kannst du Linux direkt auf deine..."
tags: [Entwicklung, Git installieren, Linux auf Windows, Linux-Anleitung, Linux-Integration, Microsoft Store, Paketquellen aktualisieren, Software-Entwicklung, Ubuntu 24.04, Ubuntu Einrichtung, Ubuntu installieren, VirtualMachinePlatform, Windows Subsystem for Linux, Windows-Features aktivieren, WSL, WSL 2]
author: 
  name: "Christian Storb" 
  url: "/author/christian-storb/"
image: /assets/images/consulting/blog/wsl-auf-windows.jpg
locale: "de_DE"
seo:
  type: BlogPosting
---

Die Kombination von Windows und Linux in einem System bietet unschätzbare Flexibilität. Mit Windows Subsystem for Linux (WSL) kannst du Linux direkt auf deinem Windows-Rechner ausführen. **Dieser Artikel konzentriert sich auf praktische Beispiele mit minimaler Erläuterung**, um dir eine klare und einfache Anleitung zu bieten.

### Warum WSL?

WSL ermöglicht die Ausführung eines vollständigen Linux-Subsystems direkt auf Windows – ohne Dual-Boot oder virtuelle Maschinen. Es ist ideal für Entwickler und Power-User, die die nahtlose Integration beider Betriebssysteme nutzen möchten.

### **Schritt 1: WSL über die Benutzeroberfläche aktivieren**

- Öffne das **Startmenü** und suche nach „Windows-Features“.

- Klicke auf **Windows-Features aktivieren oder deaktivieren**.

- Scrolle nach unten und setze ein Häkchen bei **Windows-Subsystem für Linux**.

- Aktiviere auch **Plattform für virtuelle Computer**, um WSL 2 zu unterstützen.

- Bestätige mit **OK** und lasse die Änderungen installieren.

- Starte deinen PC neu.

### **Schritt 2: WSL 2 aktivieren**

Die Version 2 von WSL bietet signifikante Leistungsverbesserungen. So aktivierst du sie:

- Öffne PowerShell als Administrator.

- Gib diesen Befehl ein:<br>`wsl --set-default-version 2 `<br>Falls eine Fehlermeldung erscheint, installiere das WSL 2-Kernel-Update von Microsoft.

### **Schritt 3: Ubuntu 24.04 aus dem Microsoft Store installieren**

- Öffne den **Microsoft Store**.

- Suche nach „Ubuntu“ und wähle die Version „Ubuntu 24.04“.

- Klicke auf **Installieren** und warte, bis der Prozess abgeschlossen ist.

- Starte anschließend Ubuntu über das Startmenü oder gib `wsl` in die Suchleiste ein.

### **Schritt 4: Erste Einrichtung von Ubuntu**

Beim ersten Start wirst du aufgefordert, einen Benutzernamen und ein Passwort zu erstellen. Diese gelten nur für dein Linux-System.

### **Schritt 5: Ubuntu einrichten**

- Aktualisiere die Paketquellen:<br>`sudo apt update && sudo apt upgrade -y`

- Installiere wichtige Tools wie `git`:<br>`sudo apt install git`

### **Schritt 6: Überprüfe deine Internetverbindung**

- Stelle sicher, dass dein System mit dem Internet verbunden ist.

- Teste die Verbindung mit einem einfachen Befehl wie:<br>`ping google.com`

### **Schritt 7: DSN-Server überprüfen**

<p>Falls ein Problem mit der Internetverbindung besteht, könnte es an deinem DNS-Server liegen. Du kannst temporär auf einen öffentlichen DNS-Server wie Google DNS wechseln:<br>`sudo nano /etc/resolv.conf`<br><br>Füge folgende Zeile hinzu:<br>`nameserver 8.8.8.8`
</p>

### **Fazit**

Mit WSL und Ubuntu 24.04 kannst du die Vorteile von Linux nutzen, ohne Windows verlassen zu müssen. Diese Kombination ist perfekt für Entwicklung, Experimentieren und produktives Arbeiten. Ich hoffe, dieser Leitfaden erleichtert dir den Einstieg – viel Erfolg!

### Referenzen

- [Ubuntu beim Start von Windows automatisch starten: Ein Leitfaden](https://storbconsulting.wordpress.com/2025/03/15/ubuntu-beim-start-von-windows-automatisch-starten-ein-leitfaden/)
