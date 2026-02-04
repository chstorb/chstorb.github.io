---
layout: default
title: "Ausgewählte Unternehmen"
description: "Referenzen von STORB Consulting: Sehen Sie hier eine Auswahl an Unternehmen und Partnern, mit denen wir erfolgreich IT- und Management-Projekte realisiert haben."
permalink: /references/featured-companies/
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
categories: [references, companies, consulting]
tags: [Unternehmen, Referenzen, Consulting, Projekte, Partnerschaften]
---

<div class="container">
  <!-- Intro -->
  <div class="row justify-content-center mb-5">
    <div class="col-lg-10 text-center">
      <h1 class="display-5 fw-bold mb-4">{{ site.data.featured_companies.intro.headline }}</h1>
      <p class="lead text-muted col-lg-8 mx-auto">
        {{ site.data.featured_companies.intro.text }}
      </p>
    </div>
  </div>

  <!-- Companies Grid -->
  <div class="row row-cols-1 row-cols-sm-2 row-cols-md-3 g-4 mb-5 justify-content-center">
    {% for company in site.data.featured_companies.companies %}
      <div class="col">
        <div class="card h-100 shadow-sm border-0 bg-transparent">
            <!-- Using a subtle gradient/border style for a premium look without logos -->
          <div class="card-body p-4 text-center d-flex flex-column justify-content-center align-items-center bg-body-tertiary rounded-3 hover-lift transition-all">
             <div class="mb-3 text-primary opacity-50">
                <span class="material-symbols-outlined fs-2">apartment</span>
             </div>
             <h2 class="h5 fw-bold mb-0 text-body">{{ company.name }}</h2>
          </div>
        </div>
      </div>
    {% endfor %}
  </div>

  <!-- Back Link -->
  <div class="row justify-content-center text-center">
    <div class="col-12">
      <a href="{{ '/references/references/' | relative_url }}" class="btn btn-link text-decoration-none">
        <span class="material-symbols-outlined align-middle me-1">arrow_back</span>
        Zurück zur Übersicht
      </a>
    </div>
  </div>
</div>

<style>
.hover-lift {
  transition: transform 0.2s ease, box-shadow 0.2s ease;
}
.hover-lift:hover {
  transform: translateY(-5px);
  box-shadow: 0 .5rem 1rem rgba(0,0,0,.15)!important;
}
</style>
