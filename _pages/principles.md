---
layout: default
title: "Unternehmensgrundsätze"
description: "Die Unternehmensgrundsätze von STC STORB Consulting – Unabhängigkeit, Objektivität, Kompetenz und Vertraulichkeit."
permalink: /principles/
author: "Christian Storb"

# Open Graph / Twitter Cards
image: "/assets/images/consulting/og-image.png"
twitter:
  card: "summary_large_image"
  creator: "@ChristianStorb"

robots: "index, follow"
categories: [principles, consulting]
tags: [Grundsätze, Unternehmenswerte, Consulting, Unabhängigkeit, Objektivität, Kompetenz, Vertraulichkeit]
---

<div class="container">
  <div class="row justify-content-center mb-5">
    <div class="col-lg-8 text-center">
      <p class="lead fst-italic">
        "Neue Wege zu beschreiten hat bei uns Tradition."
      </p>
      <p>
        Bei allem Wandel bleiben unsere Unternehmensgrundsätze unverändert – sie bilden das Gleichgewicht unserer Geschäftstätigkeit und sind die Basis für nachhaltige Beratungserfolge.
      </p>
    </div>
  </div>

  <div class="row row-cols-1 row-cols-md-2 g-4">
    {% for item in site.data.principles %}
      <div class="col">
        <div class="card h-100 shadow-sm border-0">
          <div class="card-body text-center p-4">
            <div class="text-primary mb-3">
              {% include icon.html icon=item.icon type=item.type %}
            </div>
            <h3 class="h4 card-title mb-3">{{ item.title }}</h3>
            <p class="card-text text-muted">
              {{ item.description }}
            </p>
          </div>
        </div>
      </div>
    {% endfor %}
  </div>
</div>
