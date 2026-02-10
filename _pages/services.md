---
layout: default
title: "Unsere Services"
description: "STORB Consulting – Projektunterstützung von der Planung über die Entwicklung bis zur Markteinführung und den Betrieb."
permalink: /services
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
  <!-- Intro & Lifecycle -->
  <div class="row justify-content-center mb-5">
    <div class="col-lg-10 text-center">
      <p class="lead mb-5 col-lg-8 mx-auto">
        {{ site.data.services.intro.text }}
      </p>

      <!-- Lifecycle Steps -->
      <div class="row row-cols-2 row-cols-md-4 g-4 justify-content-center">
        {% for step in site.data.services.lifecycle %}
          <div class="col">
            <div class="d-flex flex-column align-items-center">
              <div class="p-3 bg-primary-subtle text-primary rounded-circle mb-3">
                {% include icon.html icon=step.icon type=step.type %}
              </div>
              <h5 class="h6 fw-bold">{{ step.title }}</h5>
            </div>
          </div>
        {% endfor %}
      </div>
    </div>
  </div>

  <hr class="my-5 opacity-10">

  <!-- Why STC / Benefits -->
  <div class="mb-5">
    <div class="text-center mb-4">
      <h2 class="fw-bold">{{ site.data.services.benefits_intro }}</h2>
    </div>
    <div class="row row-cols-1 row-cols-md-3 g-4">
      {% for benefit in site.data.services.benefits %}
        <div class="col">
          <div class="card h-100 shadow-sm border-0">
            <div class="card-body p-4 text-center">
              <div class="text-primary mb-3">
                {% include icon.html icon=benefit.icon type=benefit.type %}
              </div>
              <h3 class="h5 card-title fw-bold mb-3">{{ benefit.title }}</h3>
              <p class="card-text text-muted">
                {{ benefit.description }}
              </p>
            </div>
          </div>
        </div>
      {% endfor %}
    </div>
  </div>

  <!-- Expertise section -->
  <div class="row justify-content-center">
    <div class="col-lg-8">
      <div class="card bg-body-tertiary border-0">
        <div class="card-body p-4 p-md-5">
          <h3 class="h4 fw-bold mb-4 text-center">{{ site.data.services.expertise.title }}</h3>
          <ul class="list-unstyled mb-4">
            {% for point in site.data.services.expertise.bullet_points %}
              <li class="d-flex gap-3 mb-3 align-items-start">
                <span class="text-success mt-1">
                  <span class="material-symbols-outlined fs-5">check_circle</span>
                </span>
                <span>{{ point | markdownify | remove: '<p>' | remove: '</p>' }}</span>
              </li>
            {% endfor %}
          </ul>
          <p class="text-center mb-0 fst-italic">
            {{ site.data.services.expertise.location_text | markdownify | remove: '<p>' | remove: '</p>' }}
          </p>
        </div>
      </div>
    </div>
  </div>
</div>
