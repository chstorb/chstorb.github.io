const fs = require("fs");
const { getMarkdownFiles, parseFrontmatter } = require("./utils");

const REQUIRED_FIELDS = ["title", "description", "date", "tags"];

function analyzeFrontmatter(baseDir = ".") {
    const files = getMarkdownFiles(baseDir);
    const report = [];

    for (const file of files) {
        const content = fs.readFileSync(file, "utf8");
        const { frontmatter } = parseFrontmatter(content);

        const missing = REQUIRED_FIELDS.filter(f => !frontmatter[f]);
        const issues = [];

        if (missing.length > 0) {
            issues.push(`Missing fields: ${missing.join(", ")}`);
        }

        if (frontmatter.title && frontmatter.title.length > 80) {
            issues.push("Title is unusually long");
        }

        report.push({
            file,
            issues,
            frontmatter
        });
    }

    return report;
}

if (require.main === module) {
    console.log(JSON.stringify(analyzeFrontmatter("."), null, 2));
}

module.exports = analyzeFrontmatter;
