#!/usr/bin/env bash
set -euo pipefail

readonly AUTOSDK_VERSION="0.34.6"
readonly OPENAPI_URL="https://gateway.stg.cloud.pje.jus.br/domicilio-eletronico-hml/v3/api-docs"
readonly DEFAULT_BASE_URL="https://gateway.stg.cloud.pje.jus.br/domicilio-eletronico-hml"

installed_version="$(autosdk --version 2>/dev/null || true)"

if [[ "${installed_version%%+*}" != "${AUTOSDK_VERSION}" ]]; then
  dotnet tool update --global autosdk.cli --version "${AUTOSDK_VERSION}" --allow-downgrade
fi

curl --fail --silent --show-error --location --retry 3 --output openapi.json.tmp "${OPENAPI_URL}"
python3 -I apply-openapi-overrides.py openapi.json.tmp
mv openapi.json.tmp openapi.json

rm -rf Generated

autosdk generate openapi.json \
  --namespace Softplan.Soft.Suite.Dje.Sdk \
  --clientClassName DjeClient \
  --targetFramework net10.0 \
  --output Generated \
  --base-url "${DEFAULT_BASE_URL}" \
  --base-url-env DJE_BASE_URL \
  --security-scheme Http:Header:Bearer \
  --api-key-env DJE_ACCESS_TOKEN \
  --exclude-deprecated-operations

python3 -I use-date-time-offset.py Generated
