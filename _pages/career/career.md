---
layout: default
title: "Deine Karriere bei STORB Consulting"
description: "Gestalte mit uns modulare, rechtssichere Weblösungen – wir suchen erfahrene Persönlichkeiten mit Unternehmergeist."
permalink: /career/career
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
categories: [career, consulting, jobs]
tags: [Karriere, Consulting, Cloud, Architektur, Blazor, Azure]
---

<div class="container">
  <!-- Hero Section -->
  <div class="row justify-content-center text-center mb-5">
    <div class="col-lg-9">
      <h2 class="display-5 fw-bold mb-3">{{ site.data.career.intro.headline }}</h2>
      <p class="lead text-primary mb-4">
        {{ site.data.career.intro.subline }}
      </p>
      <p class="text-muted col-lg-8 mx-auto">
        {{ site.data.career.intro.text }}
      </p>
    </div>
  </div>

  <!-- Tech Stack Badges -->
  <div class="row justify-content-center mb-5">
    <div class="col-lg-8 text-center">
      <div class="d-flex flex-wrap justify-content-center gap-2">
        {% for tech in site.data.career.tech_stack %}
          <span class="badge rounded-pill bg-body-tertiary text-body-secondary border border-secondary-subtle px-3 py-2 fw-normal">
            {{ tech }}
          </span>
        {% endfor %}
      </div>
    </div>
  </div>

  <!-- Benefits Cards -->
  <div class="row row-cols-1 row-cols-md-3 g-4 mb-5">
    {% for feature in site.data.career.features %}
      <div class="col">
        <div class="card h-100 shadow-sm border-0 bg-transparent">
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

  <!-- CTA Section -->
  <div class="row justify-content-center text-center">
    <div class="col-lg-8">
      <div class="card bg-primary-subtle border-0 rounded-4">
        <div class="card-body p-5">
          <h3 class="h4 fw-bold mb-4">Bereit, Verantwortung zu übernehmen?</h3>
          <p class="mb-4">
            Wenn Sie Ideen einbringen und gemeinsam mit uns Zukunft gestalten möchten, freuen wir uns auf Sie.
          </p>
          <a href="{{ site.data.career.cta.link | relative_url }}" class="btn btn-primary btn-lg shadow-sm">
            {{ site.data.career.cta.text }}
          </a>
        </div>
      </div>
    </div>
  </div>
</div>
