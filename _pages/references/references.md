---
layout: default
title: "Referenzen"
description: "Referenzen und ausgewählte Projekte von STORB Consulting – Expertise aus verschiedenen Branchen."
permalink: /references/references/
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
categories: [references, consulting]
tags: [Referenzen, Projekte, Consulting, Branchenexpertise]
---

<div class="container">
  <!-- Intro -->
  <div class="row justify-content-center mb-5">
    <div class="col-lg-9 text-center">
      <h1 class="display-5 fw-bold mb-4">{{ site.data.references.intro.headline }}</h1>
      <p class="lead fw-normal mb-4">
        {{ site.data.references.intro.lead }}
      </p>
      <p class="text-muted mb-4 col-lg-10 mx-auto">
        {{ site.data.references.intro.text }}
      </p>
      
      <div class="d-flex flex-wrap justify-content-center gap-2 mt-4">
        {% for highlight in site.data.references.highlights %}
          <span class="badge bg-body-tertiary text-body-secondary border px-3 py-2 rounded-pill fw-normal">
            <span class="material-symbols-outlined align-middle fs-6 me-1">check</span>
            {{ highlight }}
          </span>
        {% endfor %}
      </div>
    </div>
  </div>

  <hr class="my-5 opacity-10">

  <!-- Navigation Cards -->
  <div class="row row-cols-1 row-cols-md-3 g-4">
    {% for item in site.data.references.navigation %}
      <div class="col">
        <div class="card h-100 shadow-sm border-0 transition-hover">
          <div class="card-body text-center p-4 p-md-5">
            <div class="mb-4 text-primary">
               {% include icon.html icon=item.icon type=item.type %}
            </div>
            <h3 class="h4 card-title fw-bold mb-3">{{ item.title }}</h3>
            <p class="card-text text-muted mb-4">
              {{ item.description }}
            </p>
            <a href="{{ item.url | relative_url }}" class="btn btn-outline-primary stretched-link">
              Ansehen
            </a>
          </div>
        </div>
      </div>
    {% endfor %}
  </div>
</div>

<style>
.transition-hover {
  transition: transform 0.2s ease, box-shadow 0.2s ease;
}
.transition-hover:hover {
  transform: translateY(-5px);
  box-shadow: 0 .5rem 1rem rgba(0,0,0,.15)!important;
}
</style>
