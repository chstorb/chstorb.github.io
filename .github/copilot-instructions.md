<!-- GitHub Copilot / AI agent instructions for this repository -->
# How to assist in this repository

This repository is a Jekyll-based static site (personal/consulting blog). The notes below are tailored for AI coding agents to be immediately productive when editing, building, or extending the site.

- **Project type:** Jekyll static site. Main source content lives in the repository root and `_posts/`, templates in `_layouts/`, includes in `_includes/`, data files in `_data/`, and generated output in `_site/`.
- **Primary language:** German (see `lang: "de"` and `locale: "de_DE"` in `_config.yml`). Prefer to preserve existing language unless asked to localize.

Key files you should check before making changes:

- `_config.yml` — global site configuration (permalinks, plugins, base URL, locale).
- `Gemfile` — Jekyll and plugin versions; always use `bundle exec` when running Jekyll commands.
- `_layouts/post.html` and `_layouts/default.html` — post and page layout structure.
- `_includes/*` — shared partials (e.g. `navbar.html`, `footer.html`, `mermaid.html`).
- `_posts/` — chronological content; frontmatter patterns are authoritative for post metadata.

Build / run commands (exact commands discovered in repo):

- Install dependencies: `bundle install` (or `bundle install --path vendor/bundle` for isolated installs).
- Serve locally (live reload): `bundle exec jekyll serve --livereload` (workspace task: "Jekyll Serve").
- Build static site: `bundle exec jekyll build` (output to `_site/`).

Important conventions and patterns (do not invent alternatives without confirmation):

- Frontmatter fields used commonly in `_posts/`: `layout`, `title`, `slug`, `date`, `categories`, `description`, `tags`, `author` (with nested `name` and `url`), `image`, `seo`, `redirect_from`.
  - Example post: `_posts/2025-01-23-gh-copilot-commitnachrichten-vs.md` — follow the same keys and structure.
- The site uses these Jekyll plugins (declared in `_config.yml` and `Gemfile`): `jekyll-feed`, `jekyll-sitemap`, `jekyll-seo-tag`, `jekyll-redirect-from`. Use their documented behavior when modifying templates or meta tags.
- Build artifacts and generated site: `_site/` is output — avoid editing files inside `_site/` (they are generated).
- Static assets live under `assets/` and `audio/` — preserve existing file naming and responsive image handling.

Code/style notes for contributors/agents:

- Keep markup and Liquid templating in `_layouts/` and `_includes/` consistent with existing patterns (no new global JS frameworks).
- When adding or changing frontmatter keys, search existing posts to confirm usage patterns (e.g., `seo:` blocks and `image` paths under `/assets/images/...`).
- Maintain German content and existing tone by default. If adding new copy, match locale and `lang` settings.

Integration points & external deps:

- Hosted site target: `url` in `_config.yml` is set to `https://chstorb.github.io` — verify `baseurl` when changing permalinks.
- Uses standard Jekyll plugins (see above). Do not add GitHub Pages-only gems unless intentionally switching to `github-pages`.

Safety & CI notes:

- The repo contains a `.github/workflows/` folder with skills and automation; changing build outputs may affect those workflows. Inspect `.github/workflows/` before modifying how the site is built.
- Ignore `_site/` in edits; CI regenerates it.

How to propose content changes safely:

1. Edit source files (`_posts/`, `_layouts/`, `_includes/`, `_data/`).
2. Run `bundle exec jekyll serve --livereload` locally to verify rendering and links.
3. Test redirects (if adding `redirect_from`) by building and checking the generated `_site/` pages.

If you are merging or generating new content programmatically:

- Produce frontmatter that matches existing posts exactly (same keys & nested `author` structure).
- Avoid modifying `Gemfile` or plugin list without explicit instruction — these affect everyone's local dev environment.

Where to look for examples:

- Post example: `_posts/2025-01-23-gh-copilot-commitnachrichten-vs.md`
- Layouts: `_layouts/post.html`, `_layouts/default.html`
- Includes: `_includes/navbar.html`, `_includes/footer.html`, `_includes/mermaid.html`

Questions or uncertainty:

- If a requested change touches build tooling (Bundler, plugins, Gemfile), ask for confirmation before applying.
- If a change affects site language or author metadata conventions, confirm the desired locale and author format.

If anything above is unclear or missing examples you need, tell me which area to expand and I will update this file.
