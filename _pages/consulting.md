---
layout: default
title: "Über uns"
description: "STC STORB Consulting – seit 2000 unabhängige Beratung und erfolgreiche Projekte für Unternehmen jeder Größe."
permalink: /consulting/
author: "Christian Storb"

# Open Graph / Twitter Cards
image: "/assets/images/consulting/og-image.png"
twitter:
  card: "summary_large_image"
  creator: "@ChristianStorb"

robots: "index, follow"
categories: [consulting, company]
tags: [Über uns, Consulting, Projekte, Unternehmen, Beratung, Erfolg]
---

<div class="container">
  <div class="row justify-content-center mb-5">
    <div class="col-lg-9 text-center">
      <div class="mb-3">
        <span class="badge bg-primary-subtle text-primary-emphasis rounded-pill px-3 py-2 fs-6">
          {{ site.data.consulting.intro.badge }}
        </span>
      </div>
      <h2 class="display-6 fw-bold mb-3">{{ site.data.consulting.intro.headline }}</h2>
      <p class="lead text-muted">
        {{ site.data.consulting.intro.text }}
      </p>
    </div>
  </div>

  <div class="row row-cols-1 row-cols-md-3 g-4 mb-5">
    {% for feature in site.data.consulting.features %}
      <div class="col">
        <div class="card h-100 shadow-sm border-0">
          <div class="card-body text-center p-4">
            <div class="text-primary mb-3">
              {% include icon.html icon=feature.icon type=feature.type %}
            </div>
            <h3 class="h5 card-title fw-bold mb-3">{{ feature.title }}</h3>
            <p class="card-text text-muted">
              {{ feature.description }}
            </p>
          </div>
        </div>
      </div>
    {% endfor %}
  </div>
  
  <div class="row justify-content-center">
    <div class="col-lg-8 text-center">
      <p>
        Als erfahrener Partner sind wir für alle Beratungs- und Serviceaufgaben rund um Ihr Unternehmen etabliert.
        Der kontinuierliche Erfahrungsaustausch mit unseren Kunden schafft eine solide Grundlage für die erfolgreiche Umsetzung unserer Projekte.
      </p>
    </div>
  </div>
</div>
