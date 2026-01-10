---
name: content-audit
description: >
  Analyzes Markdown content in Jekyll-based static sites, checking frontmatter,
  structure, links, readability, and SEO quality.
---

# Content Audit Skill

## Purpose
Improve the clarity, consistency, and search visibility of Markdown files in a Jekyll project.  
The skill inspects frontmatter, headings, links, images, and overall text quality.

## When to Use This Skill
- Reviewing new blog posts before publishing  
- Auditing existing pages for consistency  
- Improving SEO and internal linking  
- Ensuring accessibility and clean structure  

## Instructions

### 1. Collect Markdown Files
- Load all `.md` files from `_posts`, `_pages`, and the project root.
- Ignore files inside `_site` or other build output directories.

### 2. Analyze Frontmatter
For each file:
- Check for required fields: `title`, `description`, `date`, `tags`.
- Detect missing, duplicated, or inconsistent metadata.
- Suggest improvements to naming, tagging, and permalink structure.

### 3. Evaluate Content Structure
- Inspect heading hierarchy (`h1` → `h2` → `h3`).
- Identify overly long sections or missing introductions.
- Suggest clearer, more concise phrasing where appropriate.

### 4. Check Internal and External Links
- Verify internal links match existing pages or posts.
- Flag broken or unreachable external URLs.
- Recommend internal cross-links to related content.

### 5. Audit Images
- Ensure each image has an `alt` attribute.
- Detect missing or unused image references.
- Suggest more descriptive alt text when needed.

### 6. SEO and Readability Review
- Highlight passive voice, long sentences, or unclear passages.
- Suggest meta descriptions based on the content.
- Recommend keywords