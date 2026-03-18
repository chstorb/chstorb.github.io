---
layout: default
title: "AdCanvas"
description: "Eine leichte, modulare Werbe‑ und Content‑Engine für moderne Websites."
version: "1.0.0"
date: 2026-03-07 12:00:00 +0100
nuget_id: null
repo_url: "https://github.com/chstorb/adcanvas"
---

<div class="container">

  <!-- Intro -->
  <div class="row justify-content-center mb-5">
    <div class="col-lg-9 text-center">
      <div class="mb-3">
         <img src="/assets/images/adcanvas.png" class="img-fluid" width="40%" alt="AdCanvas">
      </div>
      <p class="lead mb-3">
        Eine leichte, modulare Werbe‑ und Content‑Engine für moderne Websites.
      </p>
      <h3 class="mt-4">Warum AdCanvas?</h3>
      <p class="text-muted">
        AdCanvas ist ein framework‑agnostisches Rendering‑System für Anzeigen und Content‑Module.
        Es ist schnell, modular, leichtgewichtig und funktioniert in jeder Umgebung – von statischen
        Seiten bis zu komplexen Web‑Apps.
      </p>
    </div>
  </div>

  <hr class="my-5 opacity-10">

    <ul class="list-group mb-4">
        <li class="list-group-item">⚡ Keine Abhängigkeiten – funktioniert überall</li>
        <li class="list-group-item">🎨 Mehrere Layouts: List, Multiplex, In‑Feed, Sidebar, Hero, Carousel</li>
        <li class="list-group-item">🧩 Themes: Light, Dark, Premium</li>
        <li class="list-group-item">📦 Einfache Integration über CDN</li>
        <li class="list-group-item">🛠️ Entwickelt für Publisher, Blogs und Content‑Plattformen</li>
    </ul>

    <h3 class="mt-5">Installation</h3>

    <h4 class="mt-4">CDN</h4>
    <pre>
&lt;link rel="stylesheet" href="https://cdn.example.com/adcanvas.min.css"&gt;
&lt;script type="module" src="https://cdn.example.com/adcanvas.min.js"&gt;&lt;/script&gt;
    </pre>

    <h3 class="mt-5">Quickstart</h3>
    <p>Ein einfaches Beispiel mit dem <strong>List Layout</strong>:</p>

    <div class="demo-block mb-3 p-3 border rounded bg-light">
        <div class="adcanvas-ad-slot" data-layout="list" data-count="3" data-label="Anzeige"></div>
    </div>

    <pre>
&lt;div class="adcanvas-ad-slot" data-layout="list" data-count="3" data-label="Anzeige"&gt;&lt;/div&gt;
    </pre>

    <h3 class="mt-5">Layouts</h3>

    <h4 class="mt-4">List Layout</h4>
    <div class="demo-block mb-4 p-3 border rounded bg-light">
        <div class="adcanvas-ad-slot" data-layout="list" data-count="3"></div>
    </div>

    <h4>Multiplex Layout</h4>
    <div class="demo-block mb-4 p-3 border rounded bg-light">
        <div class="adcanvas-ad-slot" data-layout="multiplex" data-count="6"></div>
    </div>

    <h4>In‑Feed Layout</h4>
    <div class="demo-block mb-4 p-3 border rounded bg-light">
        <div class="adcanvas-ad-slot" data-layout="infeed" data-count="3"></div>
    </div>

    <h4>Sidebar Layout</h4>
    <div class="demo-block mb-4 p-3 border rounded bg-light">
        <div class="adcanvas-ad-slot" data-layout="sidebar" data-count="2"></div>
    </div>

    <h4>Hero Layout</h4>
    <div class="demo-block mb-4 p-3 border rounded bg-light">
        <div class="adcanvas-ad-slot" data-layout="hero" data-count="1"></div>
    </div>

    <h4>Carousel Layout</h4>
    <div class="demo-block mb-4 p-3 border rounded bg-light">
        <div class="adcanvas-ad-slot" data-layout="carousel" data-count="10" data-autoplay="true" data-interval="3000"></div>
    </div>

    <h3 class="mt-5">Themes</h3>

    <h4 class="mt-4">Dark Theme</h4>
    <div class="demo-block mb-4 p-3 border rounded bg-dark text-white">
        <div class="adcanvas-ad-slot" data-layout="list" data-theme="dark" data-count="2"></div>
    </div>

    <h4>Premium Theme</h4>
    <div class="demo-block mb-4 p-3 border rounded bg-light">
        <div class="adcanvas-ad-slot" data-layout="multiplex" data-theme="premium" data-count="4"></div>
    </div>

    <hr class="my-5">

    <p>
        Weitere Informationen findest du im
        <a href="{{ page.repo_url }}" class="fw-semibold">GitHub‑Repository</a>.
    </p>

</div>
