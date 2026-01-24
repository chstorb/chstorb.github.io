---
layout: post
title: "Semantischen Versionierung"
date: 2025-05-01 12:22:00 +0100
categories: [Open Source, Programmierung, Softwareentwicklung, Systemadministration, Technologie]
description: "Änderung der Versionsnummer nach einem Bugfix Die Änderung der Versionsnummer nach einem Bugfix folgt in der Regel dem Prinzip der . Dabei wird die Versionsnu..."
tags: [API-Kompatibilität, Bugfix, Code-Qualität, Entwicklung, Git, GitHub, Major-Update, Minor-Update, Patch-Update, Release-Management, Semantische Versionierung, SemVer, Software-Wartung, Versionierungsstrategie, Versionsverwaltung]
author: "Christian Storb"
image: /assets/images/consulting/blog/softwareentwicklerin.webp
locale: "de_DE"
seo:
  type: BlogPosting
---

## Änderung der Versionsnummer nach einem Bugfix

Die Änderung der Versionsnummer nach einem Bugfix folgt in der Regel dem Prinzip der [Semantischen Versionierung (SemVer)](https://semver.org). Dabei wird die Versionsnummer in der Form **MAJOR.MINOR.PATCH** dargestellt.

Da ein Bugfix eine **rückwärtskompatible Fehlerbehebung** ist und keine neuen Funktionen oder breaking changes einführt, sollte üblicherweise **nur die PATCH-Nummer erhöht werden**. Beispiel:

- Vor dem Bugfix: `1.2.3`

- Nach dem Bugfix: `1.2.4`

Falls das Bugfix jedoch mit einer **wesentlichen Änderung oder einem notwendigen Anpassungsschritt für die Nutzer** einhergeht, könnte auch die MINOR-Version erhöht werden (`1.3.0`).

Viele Projekte verwenden außerdem zusätzliche **Build- und Release-Tags** (`1.2.4-beta`, `1.2.4+20250501`), um den genauen Zustand einer Version zu kennzeichnen.

## Referenzen
- [Semantische Versionierung](https://semver.org)
