---
layout: default
title: "Blog"
permalink: /blog/
---

# Blog

{% for post in site.posts %}
- [{{ post.title }}]({{ post.url }}) – {{ post.date | date: "%d.%m.%Y" }}
{% endfor %}
