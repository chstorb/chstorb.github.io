const fs = require("fs");
const path = require("path");
const { getMarkdownFiles } = require("./utils");
const https = require("https");

function extractLinks(content) {
    const regex = /

    \[.*?\]

    \((.*?) \)/g;
    const links = [];
    let match;

    while ((match = regex.exec(content)) !== null) {
        links.push(match[1]);
    }

    return links;
}

function checkExternalLink(url) {
    return new Promise(resolve => {
        https
            .get(url, res => resolve(res.statusCode < 400))
            .on("error", () => resolve(false));
    });
}

async function checkLinks(baseDir = ".") {
    const files = getMarkdownFiles(baseDir);
    const report = [];

    for (const file of files) {
        const content = fs.readFileSync(file, "utf8");
        const links = extractLinks(content);

        const fileReport = { file, brokenInternal: [], brokenExternal: [] };

        for (const link of links) {
            if (link.startsWith("http")) {
                const ok = await checkExternalLink(link);
                if (!ok) fileReport.brokenExternal.push(link);
            } else {
                const target = path.join(path.dirname(file), link);
                if (!fs.existsSync(target)) fileReport.brokenInternal.push(link);
            }
        }

        report.push(fileReport);
    }

    return report;
}

if (require.main === module) {
    checkLinks(".").then(r => console.log(JSON.stringify(r, null, 2)));
}

module.exports = checkLinks;
