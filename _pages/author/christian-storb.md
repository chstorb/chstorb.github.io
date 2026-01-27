---
layout: default
title: "Christian Storb"
permalink: /author/christian-storb/
description: "Christian Storb – Inhaber von STORB Consulting. Fundierte Ausbildung, langjährige Erfahrung und klare Schwerpunkte."
author: "Christian Storb"
locale: "de_DE"
seo: 
  type: ProfilePage
robots: "index, follow"
categories: [author, profile, consulting]
---

<div class="container">
  
  <div class="row g-5">
    <!-- Left Column: Profile & Philosophy -->
    <div class="col-lg-5">
      <div class="sticky-lg-top" style="top: 2rem; z-index: 1;">
        <!-- Profile Card -->
        <div class="card border-0 shadow-sm bg-body-tertiary mb-4">
          <div class="card-body p-4 text-center">
             <img src="/assets/images/consulting/authors/christian-storb.jpg" alt="Christian Storb" class="mb-3 mx-auto rounded-circle shadow-sm" style="width: 80px; height: 80px; object-fit: cover;">
             <h1 class="h3 fw-bold mb-1">{{ site.data.contacts.profile.name }}</h1>
             <p class="text-primary fw-medium mb-3">{{ site.data.contacts.profile.role }}</p>
             
             <hr class="my-4 opacity-10">

             <div class="text-start">
               <h6 class="text-uppercase text-muted small fw-bold mb-3">Qualifikation</h6>
               <ul class="list-unstyled mb-4">
                 {% for qual in site.data.contacts.qualifications %}
                   <li class="d-flex align-items-center mb-2">
                     <span class="material-symbols-outlined text-success me-2 fs-6">check_circle</span>
                     {{ qual }}
                   </li>
                 {% endfor %}
               </ul>

               <h6 class="text-uppercase text-muted small fw-bold mb-3">Schwerpunkte</h6>
               <div class="d-flex flex-wrap gap-2">
                 {% for focus in site.data.contacts.focus_areas %}
                   <span class="badge bg-primary-subtle text-primary-emphasis rounded-pill fw-normal px-3 py-2">
                     {{ focus }}
                   </span>
                 {% endfor %}
               </div>
             </div>
          </div>
        </div>

        <!-- Philosophy -->
        <div class="card border-0 shadow-sm mb-4">
           <div class="card-body p-4">
              <h5 class="card-title fw-bold mb-3">Unsere Philosophie</h5>
              {% for para in site.data.contacts.profile.philosophy %}
                <p class="text-muted small mb-3 last-mb-0">{{ para }}</p>
              {% endfor %}
           </div>
        </div>

        <!-- Contact Info (Author specific additions could go here, or just stick to the requested structure) -->
         <div class="card border-0 shadow-sm">
           <div class="card-body p-4">
              <h5 class="card-title fw-bold mb-3">Kontakt</h5>
              <ul class="list-unstyled mb-0">
                  <li class="mb-2">
                      <a href="mailto:{{ site.author.email }}" class="text-decoration-none d-flex align-items-center">
                          <span class="material-symbols-outlined me-2 fs-5">mail</span>
                          {{ site.author.email }}
                      </a>
                  </li>
                  <li class="mb-2">
                      <a href="{{ site.author.linkedin }}" target="_blank" rel="noopener" class="text-decoration-none d-flex align-items-center">
                          <span class="material-symbols-outlined me-2 fs-5">link</span>
                          LinkedIn
                      </a>
                  </li>
                   <li>
                      <a href="{{ site.author.github }}" target="_blank" rel="noopener" class="text-decoration-none d-flex align-items-center">
                          <span class="material-symbols-outlined me-2 fs-5">code</span>
                          GitHub
                      </a>
                  </li>
              </ul>
           </div>
        </div>

      </div>
    </div>

    <!-- Right Column: Publications -->
    <div class="col-lg-7">
      <h2 class="h4 border-bottom pb-3 mb-4">Veröffentlichungen</h2>
      
      <div class="timeline">
        {% assign author_posts = site.posts | where_exp: "item", "item.author == 'Christian Storb' or item.author.name == 'Christian Storb'" %}
        {% for post in author_posts %}
          <div class="timeline-item position-relative ps-4 pb-5 last-pb-0">
             <!-- Dot -->
             <div class="position-absolute start-0 top-0 translate-middle-x bg-primary rounded-circle border border-4 border-body" style="width: 16px; height: 16px; margin-top: 0.4rem;"></div>
             <!-- Content -->
             <div class="card border-0 shadow-sm h-100">
               <div class="card-body p-4">
                 <div class="d-flex justify-content-between align-items-start mb-2">
                    <span class="badge bg-secondary-subtle text-body-secondary">{{ post.date | date: "%d.%m.%Y" }}</span>
                    {% if post.categories %}
                        <div class="d-flex gap-1">
                        {% for cat in post.categories limit:2 %}
                             <span class="badge bg-light text-dark border">{{ cat }}</span>
                        {% endfor %}
                        </div>
                    {% endif %}
                 </div>
                 <h3 class="h5 fw-bold mb-2">
                    <a href="{{ post.url }}" class="text-decoration-none text-reset">{{ post.title }}</a>
                 </h3>
                 <p class="card-text text-muted mb-3">
                    {{ post.excerpt | strip_html | truncatewords: 30 }}
                 </p>
                 <a href="{{ post.url }}" class="fw-medium text-decoration-none">
                    Artikel lesen <span class="material-symbols-outlined fs-6 align-text-bottom">arrow_forward</span>
                 </a>
               </div>
             </div>
          </div>
        {% endfor %}
      </div>
    </div>
  </div>

</div>

<style>
.timeline {
  border-left: 2px solid var(--bs-border-color);
  margin-left: 0.5rem;
}
.last-mb-0:last-child {
  margin-bottom: 0 !important;
}
.last-pb-0:last-child {
  padding-bottom: 0 !important;
}
</style>

