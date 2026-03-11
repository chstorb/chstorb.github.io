---
layout: product
title: "AdCanvas"
version: "1.1.0"
date: 2026-03-08 12:00:00 +0100
nupkg_id: "AdCanvas"
repo_url: "https://github.com/chstorb/AdCanvas"
description: "A lightweight, framework‑agnostic ad rendering engine."
license: "https://opensource.org/licenses/MIT"
programmingLanguage: "JavaScript"
permalink: /products/adcanvas/
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
categories: [products, adcanvas]
tags: [AdCanvas, Demo, Produkte]
---

<h2>AdCanvas – Demo</h2>
<p>A lightweight, framework‑agnostic ad rendering engine.</p>

<!-- Multiplex grid layout, 6 ads, dark theme -->
<div class="adcanvas-ad-slot" 
     data-layout="multiplex" 
     data-count="6" 
     data-theme="dark"></div>

<!-- Carousel with autoplay -->
<div class="adcanvas-ad-slot" 
     data-layout="carousel" 
     data-count="10" 
     data-autoplay="true" 
     data-interval="4000"></div>

<!-- Premium hero layout -->
<div class="adcanvas-ad-slot" 
     data-layout="hero" 
     data-count="1" 
     data-theme="premium"></div>