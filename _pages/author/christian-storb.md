---
layout: default
title: "Christian Storb"
permalink: /author/christian-storb/
---

# Christian Storb

**Inhaber von STORB Consulting.**  
Diplom‑Betriebswirt (FH) und Industriekaufmann mit Schwerpunkten in Organisation, Datenverarbeitung sowie Rechnungswesen und Controlling.   

## Kurzbiografie
STORB Consulting wurde 2000 gegründet. Christian Storb bringt langjährige praktische Berufserfahrung in Beratung und Anwendungsentwicklung mit. 

## Fachgebiete
- Organisation
- Datenverarbeitung
- Rechnungswesen / Controlling
- Beratung für Projekte vor Ort

## Veröffentlichungen
{% for post in site.posts %}
  {% if post.author == "Christian Storb" or post.author.name == "Christian Storb" %}
  - [{{ post.title }}]({{ post.url }}) — {{ post.date | date: "%Y" }}
  {% endif %}
{% endfor %}

## Kontakt
- E‑Mail: [{{ site.author.email }}](mailto:{{ site.author.email }})
- LinkedIn: [{{ site.author.linkedin }}]({{ site.author.linkedin }})
- GitHub: [{{ site.author.github }}]({{ site.author.github }})

