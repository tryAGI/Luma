# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [Luma AI](https://lumalabs.ai/) Dream Machine video and image generation platform, auto-generated from the Luma OpenAPI specification using [AutoSDK](https://github.com/HavenDV/AutoSDK). Published as a NuGet package under the `tryAGI` organization.

## Build Commands

```bash
# Build the solution
dotnet build Luma.slnx

# Build for release (also produces NuGet package)
dotnet build Luma.slnx -c Release

# Run integration tests (requires LUMA_API_KEY env var)
dotnet test src/tests/IntegrationTests/Luma.IntegrationTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/Luma && ./generate.sh
```

## Architecture

### Code Generation Pipeline

The SDK code is **entirely auto-generated** — do not manually edit files in `src/libs/Luma/Generated/`.

1. `src/libs/Luma/openapi.yaml` — the Luma OpenAPI spec (fetched from `https://raw.githubusercontent.com/lumalabs/lumaai-api/refs/heads/main/openapi.yaml`)
3. `src/libs/Luma/generate.sh` — orchestrates: download spec → fix spec → run AutoSDK CLI → output to `Generated/`
4. CI auto-updates the spec every 3 hours and creates PRs if changes are detected

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/Luma/` | Main SDK library (`LumaClient`) |
| `src/tests/IntegrationTests/` | Integration tests against real Luma API |

### Documentation Generation

Tests in `src/tests/IntegrationTests/Examples` are the single source of truth for both test coverage and documentation:
- Each file has a JSDoc header (`order`, `title`, `slug`) consumed by `autosdk docs sync .`
- Comments prefixed with `////` become prose paragraphs in generated docs
- CI workflow (`.github/workflows/mkdocs.yml`) auto-generates `docs/examples/` and populates `EXAMPLES:START/END` markers in README.md, docs/index.md, and mkdocs.yml
- Config: `autosdk.docs.json` points to `src/tests/IntegrationTests/Examples`

### Build Configuration

- **Target:** `net10.0` (single target)
- **Language:** C# 13 preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + AwesomeAssertions

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
