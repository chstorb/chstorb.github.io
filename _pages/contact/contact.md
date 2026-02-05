---
layout: default
title: "Kontakt"
description: "Nehmen Sie Kontakt mit STORB Consulting auf – wir beraten Sie von der Planung bis zum Betrieb."
permalink: /contact/contact/
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
categories: [contact, consulting]
tags: [Kontakt, Consulting, Cloud, Architektur, Blazor, Azure]
---

<div class="container">
  <!-- Intro -->
  <div class="row justify-content-center mb-5">
    <div class="col-lg-8 text-center">
      <h2 class="display-5 fw-bold mb-4">{{ site.data.contact.intro.headline }}</h2>
      <p class="lead text-muted mb-4">
        {{ site.data.contact.intro.text }}
      </p>
      <p class="text-body-secondary">
        {{ site.data.contact.intro.subtext }}
      </p>
    </div>
  </div>

  <!-- Contact Cards -->
  <div class="row row-cols-1 row-cols-md-2 g-4 justify-content-center mb-5">
    
    <!-- Phone -->
    <div class="col">
      <div class="card h-100 shadow-sm border-0 text-center hover-lift">
        <div class="card-body p-4">
          <div class="mb-3 text-primary">
            {% include icon.html icon=site.data.contact.contact_info.mobile.icon type="material" %}
          </div>
          <h5 class="card-title">{{ site.data.contact.contact_info.mobile.label }}</h5>
          <p class="card-text text-muted mb-4">{{ site.data.contact.contact_info.mobile.value }}</p>
          <a href="{{ site.data.contact.contact_info.mobile.href }}" class="btn btn-outline-primary stretched-link">
            Anrufen
          </a>
        </div>
      </div>
    </div>

    <!-- Email -->
    <div class="col">
      <div class="card h-100 shadow-sm border-0 text-center hover-lift">
        <div class="card-body p-4">
          <div class="mb-3 text-primary">
             {% include icon.html icon=site.data.contact.contact_info.email.icon type="material" %}
          </div>
          <h5 class="card-title">{{ site.data.contact.contact_info.email.label }}</h5>
          <p class="card-text text-muted mb-4">{{ site.data.contact.contact_info.email.value }}</p>
          <a href="{{ site.data.contact.contact_info.email.href }}" class="btn btn-primary stretched-link">
            E-Mail schreiben
          </a>
        </div>
      </div>
    </div>

  </div>

  <!-- Links -->
  <div class="row justify-content-center">
      <div class="col-lg-6 text-center">
         {% for link in site.data.contact.links %}
            <a href="{{ link.url | relative_url }}" class="btn btn-link text-decoration-none btn-lg">
                <span class="material-symbols-outlined align-middle me-2">arrow_forward</span>
                {{ link.title }}
            </a>
         {% endfor %}
      </div>
  </div>

</div>