<div align="center">
  <img src="assets/nuget-icon.png" alt="DJE CNJ .NET SDK" width="112" />
  <h1>DJE CNJ .NET SDK</h1>
  <p><strong>A .NET client for the CNJ Domicílio Judicial Eletrônico API, with OAuth2 client credentials built in.</strong></p>
  <p>Generated C# operations from the DJE OpenAPI specification, plus one small hand-written layer that gets and renews the access token and sends the User-Agent the CNJ requires.</p>

  [![CI](https://github.com/softplan/softplan-soft-suite-dje-sdk-dotnet/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/softplan/softplan-soft-suite-dje-sdk-dotnet/actions/workflows/dotnet.yml)
  [![License: MIT](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
  [![.NET 10](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
</div>

---

> [!NOTE]
> This community SDK is maintained by Softplan and generated from the DJE OpenAPI specification. It is not an official CNJ SDK.

## What you get

- **Generated operations.** 80 operations in 24 sub-clients on `DjeClient`, with typed parameters and enums, cancellation support, and source-generated `System.Text.Json` serialization.
- **Client credentials authentication.** `DjeClient.CreateWithClientCredentials` fetches the access token, caches it, renews it before it expires, and renews it when the API answers 401.
- **The User-Agent the CNJ requires.** The CNJ answers 403 to any request whose User-Agent is not `<application>/<version>/<organization>`. You pass it once, and the SDK sends it on token and API requests.
- **Tenant header as a parameter.** Operations that declare the `tenantId` header take it as a `Guid` argument.
- **Spec-driven updates.** `generate.sh` downloads the specification and regenerates the client. A scheduled workflow opens a pull request when the specification changes.
- **Release-ready packages.** MinVer derives package versions from Git tags, Source Link connects packages to source, and symbol packages improve debugging.

## Requirements

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) or later to build
- OAuth2 client credentials (client ID and client secret) for the DJE API
- The tenant ID your requests act on
- A User-Agent in the `<application>/<version>/<organization>` format

The generated default base URL and the token URL in the specification are the CNJ staging (homologation) endpoints. This SDK does not ship a production URL, so pass yours as `baseUri` and `TokenUrl`.

## Install

### NuGet.org

```bash
dotnet add package Dje.Cnj
```

### GitHub Packages

The same package is published to the [Softplan GitHub Packages registry](https://github.com/orgs/softplan/packages?repo_name=softplan-soft-suite-dje-sdk-dotnet). GitHub requires authentication to download NuGet packages.

Create a [personal access token (classic)](https://github.com/settings/tokens) with the `read:packages` scope, then register the source once:

```bash
export GITHUB_PACKAGES_USER="your-github-username"
export GITHUB_PACKAGES_TOKEN="ghp_your-read-packages-token"

dotnet nuget add source \
  --username "$GITHUB_PACKAGES_USER" \
  --password "$GITHUB_PACKAGES_TOKEN" \
  --store-password-in-clear-text \
  --name softplan \
  "https://nuget.pkg.github.com/softplan/index.json"

dotnet add package Dje.Cnj \
  --source "https://nuget.pkg.github.com/softplan/index.json"
```

Use a token limited to `read:packages`, never commit it, and authorize it for the organization if Softplan enforces SAML SSO.

## Quick start

```csharp
using System.Text.Json;
using Softplan.Soft.Suite.Dje.Sdk;

var credentials = new DjeClientCredentials
{
    TokenUrl = new Uri("https://sso.stg.cloud.pje.jus.br/auth/realms/pje/protocol/openid-connect/token"),
    ClientId = Environment.GetEnvironmentVariable("DJE_CLIENT_ID")!,
    ClientSecret = Environment.GetEnvironmentVariable("DJE_CLIENT_SECRET")!,
    UserAgent = "my-app/1.0.0/my-organization",
};

using var client = DjeClient.CreateWithClientCredentials(credentials);

var tenantId = Guid.Parse(Environment.GetEnvironmentVariable("DJE_TENANT_ID")!);

var listing = await client.Comunicacao.ObterComunicacoesOrgaoPublicoAsync(
    tenantId,
    ObterComunicacoesOrgaoPublicoStatusCiente.N,
    dataInicio: DateTimeOffset.Now.AddDays(-1),
    page: 0,
    size: 100);

using var document = JsonDocument.Parse(listing);
Console.WriteLine(document.RootElement.GetProperty("data").GetArrayLength());
```

`DjeClientCredentials` has `required` properties for `TokenUrl`, `ClientId`, `ClientSecret`, and `UserAgent`, and an optional `Scope`. `CreateWithClientCredentials` throws `ArgumentException` for a blank value or a relative `TokenUrl`. `ToString()` on the credentials leaves out the client secret.

## How authentication works

- The SDK posts `grant_type=client_credentials`, `client_id`, `client_secret`, and `scope` (when set) as a form to `TokenUrl`.
- It reads `access_token` and `expires_in` (300 seconds when the response omits it) and reuses the token until 60 seconds before it expires.
- Concurrent calls share one token request.
- When the API answers 401, the SDK requests a new token once and resends the same request, including its body. A second 401 reaches your code as an `ApiException`.
- When the token endpoint answers with a non-success status, the call throws `HttpRequestException` with that `StatusCode` and sends no API request.
- The SDK buffers each request body in memory so that it can resend it.

### Reuse your own handler

Pass a handler to control proxies, timeouts, or telemetry. The client owns the handler and disposes it.

```csharp
using var client = DjeClient.CreateWithClientCredentials(
    credentials,
    baseUri: new Uri("https://dje.example.com/gateway"),
    innerHandler: new SocketsHttpHandler { PooledConnectionLifetime = TimeSpan.FromMinutes(5) });
```

### Share the token between clients

By default each client keeps its token in memory. To share it between clients or processes, pass an `IDjeAccessTokenStore`, such as one over a distributed cache. Before each request, the SDK reads the stored token. It writes a new token when the stored one is missing, expired, or rejected with 401. Keep each token at least until its `ExpiresAt`, which is 60 seconds before the expiry the CNJ declared.

```csharp
using var client = DjeClient.CreateWithClientCredentials(credentials, tokenStore: myDistributedTokenStore);
```

The store holds a bearer token, so keep it as private as the client secret.

### Use a token you already have

The generated constructors take a static Bearer token and do not renew it:

```csharp
using var client = new DjeClient("your-access-token");
using var fromEnvironment = DjeClient.CreateFromEnvironment();
```

### Environment variables

| Variable | Read by | Purpose | Default |
|---|---|---|---|
| `DJE_ACCESS_TOKEN` | `DjeClient.CreateFromEnvironment()` | Static Bearer token | none |
| `DJE_BASE_URL` | `DjeClient.CreateFromEnvironment()`, live test | API base URL | `https://gateway.stg.cloud.pje.jus.br/domicilio-eletronico-hml` |
| `DJE_CLIENT_ID` | live test | OAuth2 client ID | none |
| `DJE_CLIENT_SECRET` | live test | OAuth2 client secret | none |
| `DJE_TENANT_ID` | live test | Tenant ID sent as `tenantId` | none |
| `DJE_USER_AGENT` | live test | User-Agent in `<application>/<version>/<organization>` format | none |
| `DJE_TOKEN_URL` | live test | Token endpoint | CNJ staging token URL |
| `DJE_SCOPE` | live test | Optional OAuth2 scope | none |

`CreateWithClientCredentials` does not read the environment. Your application passes the values in.

## API surface

`DjeClient` exposes one property per tag in the specification:

```csharp
client.AdesaoController;               client.AdminEmpresaIncorporadaController;
client.CadastroCompulsorio;            client.Coligada;
client.Comunicacao;                    client.EmpresaIncorporada;
client.ExportarPessoas;                client.Filial;
client.Matriz;                         client.Notificacoes;
client.OrgaoPublicoController;         client.OrgaoPublico;
client.Pdpj;                           client.Perfil;
client.Pessoa;                         client.PessoaFisicaRestController;
client.PessoaFisica;                   client.PessoaJuridica;
client.PessoaTermo;                    client.Representantes;
client.SolicitacaoDeVinculo;           client.TermoDeAceite;
client.Ticket;                         client.Usuario;
```

Three behaviors of the generated operations matter in practice.

- **Most operations return `byte[]`.** The specification declares the success body of 56 of the 80 operations only as `*/*`, which AutoSDK generates as raw bytes. Parse them with `System.Text.Json`. 19 operations have no response body and return `Task`. The other 5 return a typed model or `bool`.
- **Date-time filters keep their offset.** `dataInicio` and `dataFim` are `DateTimeOffset`. The SDK sends them in ISO 8601 with the offset, such as `2026-10-30T00:00:00-03:00`, and adds the fraction of a second only when there is one. `generate.sh` runs `use-date-time-offset.py` after AutoSDK, because AutoSDK types these parameters as `DateTime` and drops the offset.
- **Failures throw `ApiException`.** Read `StatusCode` and `ResponseBody`. A declared error body surfaces as `ApiException<T>`, which derives from `ApiException`.

## Regenerate the SDK

The project follows AutoSDK's [First SDK](https://autosdk.net/docs/getting-started/first-sdk) layout. `generate.sh` is the single source of truth for generation and needs `curl` and `python3`.

```bash
dotnet tool install --global autosdk.cli --version 0.34.6
cd src/libs/Dje
./generate.sh
```

The script downloads `https://gateway.stg.cloud.pje.jus.br/domicilio-eletronico-hml/v3/api-docs` into `openapi.json`, replaces `Generated/`, and creates a .NET 10 client with Bearer authentication. The gateway returns some schema properties in a different order on each request. `apply-openapi-overrides.py` sorts them so that two runs against an unchanged specification produce identical files. It also removes the accents from the tag names, so the tag `Comunicação` becomes `client.Comunicacao`.

```text
Softplan.Soft.Suite.Dje.Sdk.slnx
├── src/
│   ├── libs/Dje/
│   │   ├── Softplan.Soft.Suite.Dje.Sdk.csproj
│   │   ├── openapi.json
│   │   ├── generate.sh
│   │   ├── apply-openapi-overrides.py
│   │   ├── DjeClient.ClientCredentials.cs
│   │   ├── DjeClientCredentials.cs
│   │   ├── DjeAuthenticationHandler.cs
│   │   └── Generated/
│   └── tests/IntegrationTests/
└── .github/workflows/
```

## Build and test

```bash
dotnet restore Softplan.Soft.Suite.Dje.Sdk.slnx
dotnet build Softplan.Soft.Suite.Dje.Sdk.slnx --configuration Release --no-restore
dotnet test Softplan.Soft.Suite.Dje.Sdk.slnx --configuration Release --no-build
```

The contract tests run without a network. They check the default base URL, the Bearer header, the listing request, the token form, the User-Agent on both calls, the 401 renewal with a resent body, and token expiry. The live test runs only when `DJE_CLIENT_ID`, `DJE_CLIENT_SECRET`, `DJE_TENANT_ID`, and `DJE_USER_AGENT` are set. Otherwise MSTest marks it inconclusive.

## Versioning and releases

Packages use [MinVer](https://github.com/adamralph/minver). A stable version comes directly from a semantic Git tag:

```bash
git tag v1.0.0
git push origin v1.0.0
```

The CI workflow restores, builds, tests, and packs in `Release`. Version tags publish the same `.nupkg` to both NuGet.org and the Softplan GitHub Packages registry. GitHub Packages uses the workflow `GITHUB_TOKEN`. NuGet.org uses Trusted Publishing, which exchanges a GitHub OIDC token for a short-lived API key. For that, create the `nuget-org` environment in the repository settings, set the `NUGET_USER` Actions variable to your NuGet.org profile username, and add a Trusted Publishing policy for this repository on NuGet.org. Untagged builds are retained as artifacts and are not published.

## Contributing

1. Fork the repository and create a focused branch.
2. If the API changed, edit `generate.sh` or `apply-openapi-overrides.py` rather than the generated C# files.
3. Regenerate, then run the Release build and test commands above.
4. Open a pull request describing the upstream spec change and behavior impact.

Generated files are intentionally committed so package builds are deterministic and consumers can inspect the exact API surface.

## Security and support

- Report SDK bugs through [GitHub Issues](https://github.com/softplan/softplan-soft-suite-dje-sdk-dotnet/issues).
- For DJE behavior, credentials, or access, contact the CNJ through the channels it provides to API clients.
- Do not disclose client secrets, access tokens, or production URLs in public issues.

## License

Licensed under the [MIT License](LICENSE). The DJE API is a separate service and is subject to its own terms.
