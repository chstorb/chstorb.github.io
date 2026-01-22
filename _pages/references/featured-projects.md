---
layout: default
title: "Ausgewählte Projekte"
description: "Referenzen: Ausgewählte Projekte von STORB Consulting in IT, E-Government und Industrie."
permalink: /references/featured-projects/
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
categories: [references, projects, consulting]
tags: [Projekte, Referenzen, Consulting, IT, E-Government, Industrie]
---

<div class="container">
  <!-- Intro -->
  <div class="row justify-content-center mb-5">
    <div class="col-lg-10 text-center">
      <h1 class="display-5 fw-bold mb-4">{{ site.data.featured_projects.intro.headline }}</h1>
      <p class="lead text-muted col-lg-8 mx-auto">
        {{ site.data.featured_projects.intro.text }}
      </p>
    </div>
  </div>

  <!-- Project Grid -->
  <div class="row row-cols-1 row-cols-lg-2 g-4 mb-5">
    {% for project in site.data.featured_projects.projects %}
      <div class="col">
        <div class="card h-100 shadow-sm border-0">
          <div class="card-header bg-transparent border-0 d-flex align-items-center gap-3 pt-4 px-4">
             <div class="p-3 bg-primary-subtle text-primary rounded-3">
                {% include icon.html icon=project.icon type=project.type %}
             </div>
             <div>
               <h2 class="h5 fw-bold mb-1">{{ project.title }}</h2>
               <p class="mb-0 text-muted small text-uppercase">{{ project.subtitle }}</p>
             </div>
          </div>
          <div class="card-body px-4 pb-4">
            <p class="card-text mb-4">{{ project.description }}</p>
            
            {% if project.highlights %}
              <ul class="list-unstyled mb-0 bg-body-tertiary p-3 rounded-3">
                {% for highlight in project.highlights %}
                  <li class="d-flex align-items-start gap-2 mb-2 last-mb-0">
                    <span class="material-symbols-outlined fs-6 mt-1 text-primary">arrow_right</span>
                    <span class="small">{{ highlight }}</span>
                  </li>
                {% endfor %}
              </ul>
            {% endif %}
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
.last-mb-0:last-child {
  margin-bottom: 0 !important;
}
</style>
