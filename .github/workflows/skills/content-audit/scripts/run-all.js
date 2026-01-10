const analyzeFrontmatter = require("./analyze-frontmatter");
const checkLinks = require("./check-links");
const analyzeSEO = require("./seo-suggestions");

async function runAll(baseDir = ".") {
    const frontmatterReport = analyzeFrontmatter(baseDir);
    const linkReport = await checkLinks(baseDir);
    const seoReport = analyzeSEO(baseDir);

    return {
        summary: {
            filesChecked: frontmatterReport.length,
            frontmatterIssues: frontmatterReport.filter(f => f.issues.length > 0).length,
            brokenLinks: linkReport.reduce(
                (acc, r) => acc + r.brokenInternal.length + r.brokenExternal.length,
                0
            ),
            seoSuggestions: seoReport.reduce(
                (acc, r) => acc + r.suggestions.length,
                0
            )
        },
        frontmatter: frontmatterReport,
        links: linkReport,
        seo: seoReport
    };
}

if (require.main === module) {
    runAll(".").then(result => {
        console.log(JSON.stringify(result, null, 2));
    });
}

module.exports = runAll;
