---
layout: default
title: "Produkte von STORB Consulting"
description: "Open-Source .NET Bibliotheken und andere Produkte von Christian Storb: Fritz für AVM Fritz!Box TR-064 und Money.Unifi für SEPA-Zahlungsdateien."
permalink: /products/
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
tags: [Services, Consulting, Produkte, Microsoft, Entwicklung, Betrieb]
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
{% for product in site.products %}
  <div class="mb-5">
    <h2><a href="{{ product.url | relative_url }}">{{ product.title }}</a></h2>
    <p>{{ product.description }}</p>
    {% if product.nuget_id %}
    <p>
      <img src="https://img.shields.io/nuget/v/{{ product.nuget_id }}.svg" alt="NuGet Version">
      <img src="https://img.shields.io/nuget/dt/{{ product.nuget_id }}.svg" alt="NuGet Downloads">
    </p>
    {% endif %}
    <a href="{{ product.url | relative_url }}" class="btn btn-primary">Produkt ansehen</a>
    {% if product.nuget_id %}
    <a href="https://www.nuget.org/packages/{{ product.nuget_id }}" target="_blank" class="btn btn-secondary">NuGet installieren</a>
    {% endif %}
    {% if product.repo_url %}
    <a href="{{ product.repo_url }}" target="_blank" class="btn btn-secondary">GitHub</a>
    {% endif %}
  </div>
{% endfor %}
</div>
