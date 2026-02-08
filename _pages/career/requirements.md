---
layout: default
title: "Anforderungen an IT-Experten & Berater"
description: "Karriere bei STORB Consulting: Erfahre alles über unsere Anforderungen an Experten für IT-Consulting, Azure und Blazor. Werde jetzt Teil unseres Teams."
permalink: /career/requirements/
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
categories: [career, consulting, requirements]
tags: [Karriere, Anforderungen, Consulting, Management, Azure, Blazor]
---

<div class="container">
  <!-- Intro -->
  <div class="row justify-content-center mb-5">
    <div class="col-lg-9">
      <div class="p-4 p-md-5 bg-body-tertiary rounded-3 border-start border-primary border-5">
        <p class="lead fw-bold mb-3">
          {{ site.data.requirements.intro.text }}
        </p>
        <p class="text-muted mb-0">
          {{ site.data.requirements.intro.details }}
        </p>
      </div>
    </div>
  </div>

  <!-- Competence Grid -->
  <div class="row g-4 mb-5">
    <div class="col-md-6">
      <h2 class="h4 border-bottom pb-2 mb-3">{{ site.data.requirements.industries.title }}</h2>
      <p class="text-muted">{{ site.data.requirements.industries.description }}</p>
      <ul class="list-unstyled">
        {% for item in site.data.requirements.industries.items %}
          <li class="d-flex align-items-center gap-2 mb-2">
            <span class="material-symbols-outlined text-primary fs-5">check_circle</span>
            {{ item }}
          </li>
        {% endfor %}
      </ul>
    </div>
    <div class="col-md-6">
      <h2 class="h4 border-bottom pb-2 mb-3">{{ site.data.requirements.functional_skills.title }}</h2>
      <p class="text-muted">{{ site.data.requirements.functional_skills.description }}</p>
      <ul class="list-unstyled">
        {% for item in site.data.requirements.functional_skills.items %}
          <li class="d-flex align-items-center gap-2 mb-2">
            <span class="material-symbols-outlined text-success fs-5">add_circle</span>
            {{ item }}
          </li>
        {% endfor %}
      </ul>
    </div>
  </div>

  <!-- Tasks & Profile -->
  <div class="row g-4 mb-5">
    <div class="col-lg-12">
      <div class="card shadow-sm border-0">
        <div class="card-body p-4 p-md-5">
          <div class="row g-5">
            <div class="col-md-6">
              <h3 class="h5 fw-bold mb-3 text-primary">{{ site.data.requirements.tasks.title }}</h3>
              <ul class="list-group list-group-flush">
                {% for item in site.data.requirements.tasks.items %}
                  <li class="list-group-item bg-transparent px-0 py-2 border-light-subtle">
                    {{ item }}
                  </li>
                {% endfor %}
              </ul>
            </div>
            <div class="col-md-6">
              <h3 class="h5 fw-bold mb-3 text-primary">{{ site.data.requirements.profile.title }}</h3>
              <ul class="list-group list-group-flush">
                {% for item in site.data.requirements.profile.items %}
                  <li class="list-group-item bg-transparent px-0 py-2 border-light-subtle">
                    {{ item }}
                  </li>
                {% endfor %}
              </ul>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>

  <!-- Offer & Contact -->
  <div class="row justify-content-center">
    <div class="col-lg-8 text-center">
      <h2 class="h4 mb-4">{{ site.data.requirements.offer.title }}</h2>
      <ul class="list-unstyled mb-5 text-muted">
        {% for item in site.data.requirements.offer.items %}
          <li class="mb-2">{{ item }}</li>
        {% endfor %}
      </ul>

      <div class="card bg-primary text-white border-0 rounded-4">
        <div class="card-body p-5">
          <h3 class="h4 fw-bold mb-3">Interesse geweckt?</h3>
          <p class="mb-4">
            Gern beantwortet Ihnen {{ site.data.requirements.contact.name }} weitere Fragen.
          </p>
           <p class="fs-5 mb-4">
            <span class="material-symbols-outlined align-middle me-1">call</span>
            {{ site.data.requirements.contact.mobile }}
          </p>
          <p class="mb-4">
            Wir freuen uns auf Ihre vollständigen Bewerbungsunterlagen mit Angabe Ihrer Gehaltsvorstellung.
          </p>
          <a href="mailto:{{ site.data.requirements.contact.email }}" class="btn btn-light btn-lg px-5 shadow-sm fw-bold text-primary">
            Jetzt bewerben
          </a>
        </div>
      </div>
    </div>
  </div>
</div>
