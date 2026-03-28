#!/usr/bin/env bash
set -euo pipefail
dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -o openapi.yaml https://raw.githubusercontent.com/lumalabs/lumaai-api/refs/heads/main/openapi.yaml
autosdk generate openapi.yaml \
  --namespace Luma \
  --clientClassName LumaClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
