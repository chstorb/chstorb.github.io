---
layout: default
title: "Blog"
permalink: /blog/
description: "STORB Consulting unterstützt Ihr Projekt bei Kunden und Geschäftspartnern vor Ort – von der Planung über die Entwicklung bis zur Markteinführung und den Betrieb."
author: "Christian Storb"
locale: "de_DE"
---

# Blog

{% for post in site.posts %}
- [{{ post.title }}]({{ post.url }}) – {{ post.date | date: "%d.%m.%Y" }}
{% endfor %}
