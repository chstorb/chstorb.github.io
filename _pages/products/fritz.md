---
layout: product
title: "Fritz#"
version: "1.1.0"
date: 2026-03-08 12:00:00 +0100
nupkg_id: "Fritz"
repo_url: "https://github.com/chstorb/Fritz"    
description: "NET‑Bibliothek für eine nahtlose Anbindung der AVM‑Fritz!Box über TR‑064 – schnell, stabil, integrationsbereit."
license: "https://opensource.org/licenses/MIT"
programmingLanguage: "C#"
permalink: /products/fritz/
author: "Christian Storb"
locale: "de_DE"
seo: 
  type: WebPage

# Open Graph / Twitter Cards
image: "/assets/images/consulting/og-image.png"
twitter:
  card: "summary_large_image"
  creator: "@ChristianStorb"

robots: "index, follow"
categories: [products, fritz]
tags: [Fritz, Produkte]
---

## Overview

Fritz is a .NET library designed to simplify interaction with AVM Fritz!Box routers via the TR-064 protocol. It provides easy access to features like phonebook exports and device information.

## Quick Start

Here is a simple example of how to authenticate and export the phonebook as a CSV file.

```csharp
using Fritz;
var client = new FritzClient("http://fritz.box", "username", "password");
await client.AuthenticateAsync();
var csv = await client.Phonebook.ExportCsvAsync();
File.WriteAllText("phonebook.csv", csv);
```

For more details, visit the [GitHub Repository](https://github.com/chstorb/Fritz).
