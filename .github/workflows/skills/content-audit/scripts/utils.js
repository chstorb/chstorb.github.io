const fs = require("fs");
const path = require("path");

function getMarkdownFiles(baseDir) {
    const results = [];

    function walk(dir) {
        const entries = fs.readdirSync(dir, { withFileTypes: true });
        for (const entry of entries) {
            const fullPath = path.join(dir, entry.name);

            if (entry.isDirectory()) {
                if (!fullPath.includes("_site")) walk(fullPath);
            } else if (entry.name.endsWith(".md")) {
                results.push(fullPath);
            }
        }
    }

    walk(baseDir);
    return results;
}

function parseFrontmatter(content) {
    const match = /^---\n([\s\S]*?)\n---/.exec(content);
    if (!match) return { frontmatter: {}, body: content };

    const yaml = match[1];
    const body = content.slice(match[0].length).trim();

    const frontmatter = {};
    yaml.split("\n").forEach(line => {
        const [key, ...rest] = line.split(":");
        if (key && rest.length > 0) {
            frontmatter[key.trim()] = rest.join(":").trim();
        }
    });

    return { frontmatter, body };
}

module.exports = {
    getMarkdownFiles,
    parseFrontmatter
};
