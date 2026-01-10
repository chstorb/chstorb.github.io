const fs = require("fs");
const { getMarkdownFiles, parseFrontmatter } = require("./utils");

function countWords(text) {
    return text.split(/\s+/).filter(Boolean).length;
}

function analyzeSEO(baseDir = ".") {
    const files = getMarkdownFiles(baseDir);
    const report = [];

    for (const file of files) {
        const content = fs.readFileSync(file, "utf8");
        const { frontmatter, body } = parseFrontmatter(content);

        const words = countWords(body);
        const suggestions = [];

        if (words < 150) suggestions.push("Content is short; consider expanding.");
        if (!frontmatter.description) suggestions.push("Add a meta description.");
        if (!frontmatter.tags || frontmatter.tags.length === 0)
            suggestions.push("Add relevant tags.");

        if (!/^# /.test(body)) suggestions.push("Add a clear H1 heading at the top.");

        const longSentences = body
            .split(".")
            .filter(s => s.trim().split(" ").length > 25);

        if (longSentences.length > 0)
            suggestions.push("Some sentences are long; consider splitting them.");

        report.push({
            file,
            wordCount: words,
            suggestions
        });
    }

    return report;
}

if (require.main === module) {
    console.log(JSON.stringify(analyzeSEO("."), null, 2));
}

module.exports = analyzeSEO;
