# Content Audit Skill

This skill improves the quality, structure, and SEO of Markdown content in a Jekyll-based static site.  
It analyzes frontmatter, headings, links, images, and readability across all Markdown files in the project.

The skill is fully IDE-agnostic and compatible with any environment that implements the Agent Skills standard.

---

## Features

### 🔍 Frontmatter Analysis
- Detects missing fields (`title`, `description`, `date`, `tags`)
- Flags overly long titles or inconsistent metadata
- Extracts frontmatter for further inspection

### 🔗 Link Validation
- Checks internal links for missing targets
- Verifies external links via HTTP status
- Reports broken or unreachable URLs

### 📐 SEO & Readability Review
- Evaluates heading hierarchy
- Highlights long sentences and unclear structure
- Suggests meta descriptions and keyword improvements
- Flags short or underdeveloped content

---

## File Structure

- `SKILL.md`: Skill description and instructions
- `scripts/`
  - `utils.js`: Utility functions for file processing
  - `analyze-frontmatter.js`: Frontmatter analysis
  - `check-links.js`: Link validation
  - `seo-suggestions.js`: SEO and readability review
  - `run-all.js`: Orchestrates all checks


---

## Usage

### Run all checks

```bash
node run-all.js
```


This produces a unified JSON report containing:
- Summary statistics
- Frontmatter issues
- Broken internal/external links
- SEO and readability suggestions

---

## Notes

- The skill ignores the `_site` directory and other build outputs.
- No external dependencies are required.
- Scripts are intentionally simple and portable.
- Designed for Jekyll projects but works with any Markdown-based static site.

---

## Extending the Skill

You can add:
- A readability score module
- A keyword density analyzer
- A sitemap consistency checker
- A Jekyll build diagnostics script

The modular structure allows easy expansion.
