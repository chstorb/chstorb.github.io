---
layout: default
title: "Synergy at Work"
description: "STORB Consulting arbeitet mit starken Partnern wie 4Unit Systems Integration für ganzheitliche IT-Lösungen."
permalink: /partner/partner
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
categories: [partner, consulting]
tags: [Partner, Kooperation, IT-Dienstleistungen, Consulting, ECM, Softwareentwicklung]
---

<div class="container">
  <!-- Intro -->
  <div class="row justify-content-center mb-5">
    <div class="col-lg-9 text-center">
      <div class="mb-3 text-primary">
         <span class="material-symbols-outlined display-4">hub</span>
      </div>
      <h2 class="display-5 fw-bold mb-4">{{ site.data.partner.intro.headline }}</h2>
      <p class="lead mb-3">
        {{ site.data.partner.intro.text }}
      </p>
      <p class="text-muted">
        {{ site.data.partner.intro.subtext }}
      </p>
    </div>
  </div>

  <hr class="my-5 opacity-10">

  <!-- Partner List -->
  <div class="row justify-content-center g-4">
    {% for partner in site.data.partner.partners %}
      <div class="col-lg-10">
        <div class="card shadow-sm border-0 overflow-hidden">
          <div class="row g-0">
            <div class="col-md-4 bg-body-tertiary d-flex align-items-center justify-content-center p-4">
              <!-- Placeholder for Logo if not present, using Initials or Icon -->
              <div class="text-center">
                <span class="material-symbols-outlined text-secondary display-1 opacity-25">business</span>
                <h3 class="h5 mt-2 fw-bold text-secondary">{{ partner.name | truncatewords: 1, "" }}</h3>
              </div>
            </div>
            <div class="col-md-8">
              <div class="card-body p-4 p-md-5">
                <h3 class="h4 card-title fw-bold mb-3">{{ partner.name }}</h3>
                <p class="card-text mb-4">{{ partner.description }}</p>
                
                <h5 class="h6 fw-bold mb-3">Leistungsspektrum:</h5>
                <ul class="mb-4">
                  {% for service in partner.services %}
                    <li class="mb-1">{{ service }}</li>
                  {% endfor %}
                </ul>

                <a href="{{ partner.url }}" class="btn btn-outline-primary" target="_blank" rel="noopener">
                  <span class="material-symbols-outlined align-middle me-1 fs-5">public</span>
                  Partner-Webseite besuchen
                </a>
              </div>
            </div>
          </div>
        </div>
      </div>
    {% endfor %}
  </div>
</div>
