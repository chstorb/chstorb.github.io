---
layout: default
title: "Ausgewählte Referenzen"
description: "Referenzen zu Projekten von STORB Consulting – Bewertungen durch namhafte Unternehmen und Führungskräfte."
permalink: /references/featured-references/
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
categories: [references, testimonials, consulting]
tags: [Referenzen, Projekte, Consulting, Bewertungen, Testimonials]
---

<div class="container">
  <!-- Intro -->
  <div class="row justify-content-center mb-5">
    <div class="col-lg-10 text-center">
      <h1 class="display-5 fw-bold mb-4">{{ site.data.featured_references.intro.headline }}</h1>
      <p class="lead text-muted col-lg-8 mx-auto">
        {{ site.data.featured_references.intro.text }}
      </p>
    </div>
  </div>

  <!-- Testimonials -->
  <div class="row g-4 mb-5">
    {% for ref in site.data.featured_references.references %}
      <div class="col-12">
        <div class="card h-100 shadow-sm border-0 bg-body-tertiary">
          <div class="card-body p-4 p-lg-5">
            <div class="d-flex flex-column flex-lg-row align-items-start gap-4">
              <!-- Icon -->
              <div class="flex-shrink-0 text-primary opacity-25">
                <span class="material-symbols-outlined display-3">format_quote</span>
              </div>
              
              <!-- Content -->
              <div class="flex-grow-1">
                <figure class="mb-0">
                  <blockquote class="blockquote mb-4">
                    <p class="fs-5 fst-italic lh-lg">"{{ ref.quote }}"</p>
                  </blockquote>
                  <figcaption class="blockquote-footer mb-0 fs-6 text-body-secondary mt-3">
                    <strong class="text-body fw-bold d-block mb-1">{{ ref.role }}</strong>
                    <span class="d-block text-muted mb-2">Projekt: {{ ref.title }}</span>
                    <cite title="Source Title" class="small text-muted border-top pt-2 d-inline-block">{{ ref.date }}</cite>
                  </figcaption>
                </figure>
              </div>
            </div>
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
