---
layout: default
title: "Projekte von STORB Consulting"
description: "Open-Source .NET Bibliotheken und andere Projekte von Christian Storb: Fritz für AVM Fritz!Box TR-064 und Money.Unifi für SEPA-Zahlungsdateien. AdCanvas – eine leichte, modulare Werbe‑ und Content‑Engine für moderne Websites."
permalink: /projects/
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
categories: [services, consulting]
tags: [Services, Consulting, Projekte, Microsoft, Entwicklung, Betrieb]
---

<div class="container">
  <!-- Intro -->
  <div class="row justify-content-center mb-5">
    <div class="col-lg-10 text-center">
      <p class="lead mb-5 col-lg-8 mx-auto">
        Produkte und Open-Source .NET Bibliotheken – entwickelt für praxisnahe Anwendungsfälle im Bereich Netzwerk- und Finanzintegration.
      </p>
    </div>
  </div>
</div>

<hr class="my-5 opacity-10">

<div class="project-cards">
{% for project in site.projects %}
  <div class="mb-5">
    <h2><a href="{{ project.url | relative_url }}">{{ project.title }}</a></h2>
    <p>{{ project.description }}</p>
    {% if project.nuget_id %}
    <p>
      <img src="https://img.shields.io/nuget/v/{{ project.nuget_id }}.svg" alt="NuGet Version">
      <img src="https://img.shields.io/nuget/dt/{{ project.nuget_id }}.svg" alt="NuGet Downloads">
    </p>
    {% endif %}
    <a href="{{ project.url | relative_url }}" class="btn btn-primary">Projekt ansehen</a>
    {% if project.nuget_id %}
    <a href="https://www.nuget.org/packages/{{ project.nuget_id }}" target="_blank" class="btn btn-secondary">NuGet installieren</a>
    {% endif %}
    {% if project.repo_url %}
    <a href="{{ project.repo_url }}" target="_blank" class="btn btn-secondary">GitHub</a>
    {% endif %}
  </div>
{% endfor %}
</div>
