---
layout: default
title: "STC im Web"
description: "STC STORB Consulting – Profile und Auftritte auf verschiedenen Plattformen im Web."
permalink: /profiles/
author: "Christian Storb"

# Open Graph / Twitter Cards
image: "/assets/images/consulting/og-image.png"
twitter:
  card: "summary_large_image"
  creator: "@ChristianStorb"

robots: "index, follow"
categories: [profiles, consulting]
tags: [Profile, Consulting, Social Media, Musik, Projekte]
---

<style>
/* Optional: Slight hover effect for cards */
.hover-lift {
  transition: transform 0.2s ease-in-out;
}
.hover-lift:hover {
  transform: translateY(-5px);
}
</style>

<div class="container">
  <div class="row mb-4">
    <div class="col-lg-8">
      <p class="lead">
        STC STORB Consulting ist auf verschiedenen Plattformen vertreten. <br>
        Hier finden Sie eine Übersicht unserer Profile, Projekte und Netzwerke.
      </p>
    </div>
  </div>

  {% for category in site.data.profiles %}
    <div class="mb-5">
      <h2 class="h4 mb-3 border-bottom pb-2">{{ category.category }}</h2>
      {% if category.description %}
        <p class="text-muted mb-4">{{ category.description }}</p>
      {% endif %}
      
      <div class="row row-cols-1 row-cols-md-2 row-cols-lg-3 g-4">
        {% for item in category.items %}
          <div class="col">
            <div class="card h-100 shadow-sm border-0 hover-lift">
              <div class="card-body d-flex align-items-center gap-3">
                <div class="flex-shrink-0 text-primary">
                  {% include icon.html icon=item.icon type=item.type %}
                </div>
                <div>
                  <h5 class="card-title h6 mb-1">{{ item.title }}</h5>
                  {% if item.description %}
                    <p class="card-text small text-muted mb-0">{{ item.description }}</p>
                  {% endif %}
                </div>
                <a href="{{ item.url }}" class="stretched-link" target="_blank" rel="noopener" aria-label="{{ item.title }}"></a>
              </div>
            </div>
          </div>
        {% endfor %}
      </div>
    </div>
  {% endfor %}
</div>
