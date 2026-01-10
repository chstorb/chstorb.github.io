name: "stc-layout-redesign"
description: "Generate a modern, responsive Jekyll layout based on PRD"
author: "Christian Storb"
version: "1.0.0"
language: "en"
tags:
  - jekyll
  - layout
  - bootstrap
  - responsive
  - prd
  - webdesign
model: "Gemini 3 Pro (High)"
---

You are a senior full‑stack engineer and UX architect. Your task is to redesign my existing Jekyll website using a modern, responsive layout for both desktop and mobile.

## Context
- The site is built with Jekyll.
- Current layouts are located in /_layouts: default.html, blog.html, post.html.
- The current design uses Bootstrap but feels outdated.
- I want a clean, modular, professional design aligned with the PRD below.

## Goals
1. Create a modern, responsive layout system (desktop + mobile).
2. Provide updated versions of:
   - default.html
   - blog.html
   - post.html
3. Use clean, semantic HTML.
4. Use Bootstrap 5 (or propose a better lightweight alternative and justify it).
5. Ensure excellent Lighthouse scores (Performance, Accessibility, SEO).
6. Integrate clear CTAs and modular service sections.
7. Respect GDPR‑friendly design (local fonts, no external trackers).

## Deliverables
- Full HTML for all three layout files.
- Updated structure for header, footer, navigation, and responsive grid.
- Suggestions for CSS structure (custom.scss or assets/css/main.css).
- Optional: A minimal design system (colors, spacing, typography).

## Product Requirements Document (PRD)
[PRD.md](plans/PRD.md)

## Instructions
- Read the PRD and derive the layout structure from it.
- Explain your reasoning briefly before generating code.
- Ensure the output is production‑ready and update‑safe for Jekyll.
