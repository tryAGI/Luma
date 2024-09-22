dotnet tool install --global autosdk.cli --prerelease

autosdk init \
  Luma \
  LumaClient \
  https://raw.githubusercontent.com/lumalabs/lumaai-api/refs/heads/main/openapi.yaml \
  tryAGI \
  --output .
