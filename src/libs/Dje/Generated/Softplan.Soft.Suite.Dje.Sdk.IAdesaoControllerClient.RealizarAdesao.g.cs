#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial interface IAdesaoControllerClient
    {
        /// <summary>
        /// Realizar o cadastro administrativo de um CNPJ.<br/>
        /// Realizar o cadastro administrativo de um CNPJ com assinatura automÃ¡tica do termo mais recente.
        /// </summary>
        /// <param name="idAdmin"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task RealizarAdesaoAsync(
            long idAdmin,

            global::Softplan.Soft.Suite.Dje.Sdk.AdminRealizarAdesaoInputModel request,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Realizar o cadastro administrativo de um CNPJ.<br/>
        /// Realizar o cadastro administrativo de um CNPJ com assinatura automÃ¡tica do termo mais recente.
        /// </summary>
        /// <param name="idAdmin"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse> RealizarAdesaoAsResponseAsync(
            long idAdmin,

            global::Softplan.Soft.Suite.Dje.Sdk.AdminRealizarAdesaoInputModel request,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Realizar o cadastro administrativo de um CNPJ.<br/>
        /// Realizar o cadastro administrativo de um CNPJ com assinatura automÃ¡tica do termo mais recente.
        /// </summary>
        /// <param name="idAdmin"></param>
        /// <param name="administradorInfo"></param>
        /// <param name="matrizInfo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task RealizarAdesaoAsync(
            long idAdmin,
            global::Softplan.Soft.Suite.Dje.Sdk.AdministradorInforInputModel administradorInfo,
            global::Softplan.Soft.Suite.Dje.Sdk.MatrizInfoInputModel matrizInfo,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}