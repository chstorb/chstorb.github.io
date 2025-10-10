# BlazorWebAssemblyApp

> High-performance Blazor WebAssembly SPA with Radzen.Blazor, optimized for static hosting on GitHub Pages.

---

## Overview

This project demonstrates a modern Blazor WebAssembly Single-Page Application (SPA) utilizing the [Radzen.Blazor](https://blazor.radzen.com/) component library. The application is fully optimized for static deployment on GitHub Pages, including all required configuration and best practices for minimal application size and fast load times.

> [!TIP]
> The integration of Radzen components such as `RadzenDataGrid`, `RadzenChart`, and `RadzenForm` is a core aspect of this project.

---

## Features

- Blazor WebAssembly (.NET 9)
- Radzen.Blazor UI components (DataGrid, Chart, Form)
- Static hosting optimized for GitHub Pages
- Minimal application size via trimming and compression
- Routing workaround for GitHub Pages (`404.html`)

---

## Quick Start

1. **Clone the repository**
   ```sh
   git clone https://github.com/chstorb/chstorb.github.io.git
   cd chstorb.github.io
   ```
2. **Restore dependencies**
   ```sh
   dotnet restore
   ```
3. **Run locally**
   ```sh
   dotnet run --project BlazorWebAssemblyApp.csproj
   ```
4. **Deploy to GitHub Pages**
   See [Deployment to GitHub Pages](#deployment-to-github-pages).

---

## Example: Radzen Components

```razor
@using Radzen

<RadzenDataGrid Data="@items" TItem="Item">
    <Columns>
        <RadzenDataGridColumn TItem="Item" Property="Name" Title="Name" />
        <RadzenDataGridColumn TItem="Item" Property="Value" Title="Value" />
    </Columns>
</RadzenDataGrid>

@code {
    IEnumerable<Item> items = new[] { new Item { Name = "A", Value = 1 } };
    public class Item { public string Name { get; set; } public int Value { get; set; } }
}
```

---

## Deployment to GitHub Pages

### 1. Repository and Project Configuration

- Ensure the repository is public.
- In your `.csproj` file:

```xml
<PropertyGroup>
  <StaticWebAssetBasePath>BlazorWebAssemblyApp/</StaticWebAssetBasePath>
  <BlazorWebAssemblyEnableCompression>true</BlazorWebAssemblyEnableCompression>
  <PublishTrimmed>true</PublishTrimmed>
</PropertyGroup>
```

### 2. Base Path Adjustment in `index.html`

> [!IMPORTANT]
> Change `<base href="/">` to the repository name:

```html
<base href="/chstorb.github.io/" />
```

### 3. GitHub Actions Workflow (`.github/workflows/deploy.yml`)

```yaml
name: Deploy Blazor WASM to GitHub Pages

on:
  push:
    branches: [ master ]

jobs:
  build-deploy:
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v4
      - name: Setup .NET
        uses: actions/setup-dotnet@v4
        with:
          dotnet-version: '9.0.x'
      - name: Publish
        run: dotnet publish -c Release -o dist
      - name: Copy 404.html
        run: cp dist/wwwroot/index.html dist/wwwroot/404.html
      - name: Deploy
        uses: peaceiris/actions-gh-pages@v4
        with:
          github_token: ${{ secrets.GITHUB_TOKEN }}
          publish_dir: ./dist/wwwroot
```

### 4. 404 Error Handling

> [!NOTE]
> After publishing, copy `index.html` to `404.html` to prevent client-side routing issues on GitHub Pages.

---

## Best Practices

- Remove unused framework assemblies to minimize app size.
- Use `PublishTrimmed` and `BlazorWebAssemblyEnableCompression` in your `.csproj`.
- Integrate Radzen components efficiently to keep load times low.

---

> [!TIP]
> For further optimization and deployment guidance, refer to the official [Microsoft documentation](https://learn.microsoft.com/en-us/aspnet/core/blazor/host-and-deploy/webassembly?view=aspnetcore-9.0).
