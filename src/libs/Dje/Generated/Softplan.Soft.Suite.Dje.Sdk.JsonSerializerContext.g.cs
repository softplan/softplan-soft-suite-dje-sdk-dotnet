
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.AtualizarPerfilInputModelDeveNotificarJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.AtualizarPerfilInputModelDeveNotificarNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.AtualizarPerfilInputModelHabilitarTodosJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.AtualizarPerfilInputModelHabilitarTodosNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.EscopoPermissaoInputModelAcaoJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.EscopoPermissaoInputModelAcaoNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.EmpresaPrivadaPorteJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.EmpresaPrivadaPorteNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.EmpresaPrivadaStatusCadastroJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.EmpresaPrivadaStatusCadastroNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.EmpresaPrivadaTipoEmpresaJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.EmpresaPrivadaTipoEmpresaNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.EmpresaPrivadaTipoOrgaoPublicoJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.EmpresaPrivadaTipoOrgaoPublicoNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.EmpresaPrivadaTipoPessoaJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.EmpresaPrivadaTipoPessoaNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.EnderecoVOEstadoJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.EnderecoVOEstadoNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.INotificationTypeNotificationJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.INotificationTypeNotificationNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.IProfileRoleJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.IProfileRoleNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.PerfilNotificarJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.PerfilNotificarNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.PerfilRoleJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.PerfilRoleNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.PessoaTipoPessoaJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.PessoaTipoPessoaNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ValidationMessageTypeJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ValidationMessageTypeNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.SolicitarAberturaTicketInputModelClassificacaoJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.SolicitarAberturaTicketInputModelClassificacaoNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.CriarPessoaFisicaInputModelDeveNotificarJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.CriarPessoaFisicaInputModelDeveNotificarNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.AdicionarPerfilInputModelCargoJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.AdicionarPerfilInputModelCargoNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.AdicionarPerfilInputModelDeveNotificarJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.AdicionarPerfilInputModelDeveNotificarNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ObterVinculosOrgaoPublicoStatusJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ObterVinculosOrgaoPublicoStatusNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.DetalheVinculoOrgaoPublicoViewModelSituacaoJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.DetalheVinculoOrgaoPublicoViewModelSituacaoNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.AudienciaViewModelFormatoJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.AudienciaViewModelFormatoNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.AudienciaViewModelTipoJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.AudienciaViewModelTipoNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelCienciaAutomaticaJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelCienciaAutomaticaNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelFormatoSessaojulgamentoJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelFormatoSessaojulgamentoNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelInstanciaJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelInstanciaNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelMeioEnvioJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelMeioEnvioNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelNivelSigiloJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelNivelSigiloNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelParteInteressadaJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelParteInteressadaNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelStatusJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelStatusNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelTipoAcaoJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelTipoAcaoNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelTipoComunicacaoJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelTipoComunicacaoNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelTipoIntimacaoJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelTipoIntimacaoNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelTipoPrazoJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelTipoPrazoNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelTipoSessaojulgamentoJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelTipoSessaojulgamentoNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.PessoaViewModelTipoDocumentoJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.PessoaViewModelTipoDocumentoNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.RepresentanteViewModelStatusJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.RepresentanteViewModelStatusNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.RepresentanteViewModelTipoDocumentoJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.RepresentanteViewModelTipoDocumentoNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ObterTicketViewModelClassificacaoJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ObterTicketViewModelClassificacaoNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ObterTicketViewModelStatusJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ObterTicketViewModelStatusNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.PessoaInfoViewModelTipoPessoaJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.PessoaInfoViewModelTipoPessoaNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.GestorViewModelCargoJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.GestorViewModelCargoNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.OrgaoPublicoRepresentanteViewModelSituacaoJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.OrgaoPublicoRepresentanteViewModelSituacaoNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.PessoaPerfilViewModelStatusCadastroJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.PessoaPerfilViewModelStatusCadastroNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelCienciaAutomaticaJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelCienciaAutomaticaNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelFormatoSessaojulgamentoJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelFormatoSessaojulgamentoNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelInstanciaJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelInstanciaNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelMeioEnvioJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelMeioEnvioNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelNivelSigiloJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelNivelSigiloNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelParteInteressadaJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelParteInteressadaNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelRamoJusticaJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelRamoJusticaNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelStatusJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelStatusNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelTipoAcaoJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelTipoAcaoNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelTipoComunicacaoJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelTipoComunicacaoNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelTipoIntimacaoJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelTipoIntimacaoNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelTipoPrazoJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelTipoPrazoNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelTipoSessaojulgamentoJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelTipoSessaojulgamentoNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.PessoaProcessualOrgaoPublicoViewModelTipoDocumentoJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.PessoaProcessualOrgaoPublicoViewModelTipoDocumentoNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.PessoaRelacionadaViewModelTipoDocumentoJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.PessoaRelacionadaViewModelTipoDocumentoNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.MensagemTipoMensagemJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.MensagemTipoMensagemNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ListarCargoJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ListarCargoNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ObterComunicacoesTipoComunicacaoJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ObterComunicacoesTipoComunicacaoNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ObterComunicacoesStatusCienteJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ObterComunicacoesStatusCienteNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ObterComunicacoesParteInteressadaJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ObterComunicacoesParteInteressadaNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ObterComunicacoesModalidadeComunicacaoProcessualJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ObterComunicacoesModalidadeComunicacaoProcessualNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ObterComunicacoesOrgaoPublicoTipoComunicacaoJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ObterComunicacoesOrgaoPublicoTipoComunicacaoNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ObterComunicacoesOrgaoPublicoStatusCienteJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ObterComunicacoesOrgaoPublicoStatusCienteNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ObterComunicacoesOrgaoPublicoParteInteressadaJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ObterComunicacoesOrgaoPublicoParteInteressadaNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ObterComunicacoesOrgaoPublicoRamoJusticaJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ObterComunicacoesOrgaoPublicoRamoJusticaNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ObterComunicacoesOrgaoPublicoModalidadeComunicacaoProcessualJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ObterComunicacoesOrgaoPublicoModalidadeComunicacaoProcessualNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ListarComunicacaoTipoComunicacaoJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ListarComunicacaoTipoComunicacaoNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ListarComunicacaoCienteJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ListarComunicacaoCienteNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ListarComunicacaoParteInteressadaJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ListarComunicacaoParteInteressadaNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ListarComunicacaoModalidadeComunicacaoProcessualJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ListarComunicacaoModalidadeComunicacaoProcessualNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.InformarCienciaInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ObterInteiroTeorModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.AtualizarPerfilInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.AtualizarPerfilInputModelDeveNotificar), TypeInfoPropertyName = "AtualizarPerfilInputModelDeveNotificar2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.EscopoPermissaoInputModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.EscopoPermissaoInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.AtualizarPerfilInputModelHabilitarTodos), TypeInfoPropertyName = "AtualizarPerfilInputModelHabilitarTodos2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.EscopoPermissaoInputModelAcao), TypeInfoPropertyName = "EscopoPermissaoInputModelAcao2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.AtualizarFilialInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.EditarEnderecoInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.AtividadeEconomicaVO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.Cargo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.InfoAuditoriaVO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.InfoValidacaoValueObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.INotification>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.INotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.RecursoCargo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.RecursoCargo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.EmailSpecification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.EmpresaPrivada))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.EmpresaPrivada>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.IColiganda))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.EnderecoVO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.NaturezaJuridicaVO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.Perfil))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.EmpresaPrivadaPorte), TypeInfoPropertyName = "EmpresaPrivadaPorte2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.RepresentanteJuridicoVO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.SolicitacaoVinculo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.SolicitacaoVinculo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.EmpresaPrivadaStatusCadastro), TypeInfoPropertyName = "EmpresaPrivadaStatusCadastro2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.ITermoAceite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ITermoAceite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.PessoaTermo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.PessoaTermo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.EmpresaPrivadaTipoEmpresa), TypeInfoPropertyName = "EmpresaPrivadaTipoEmpresa2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.EmpresaPrivadaTipoOrgaoPublico), TypeInfoPropertyName = "EmpresaPrivadaTipoOrgaoPublico2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.EmpresaPrivadaTipoPessoa), TypeInfoPropertyName = "EmpresaPrivadaTipoPessoa2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.Usuario))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ValidatorPerfilInfoInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.EnderecoVOEstado), TypeInfoPropertyName = "EnderecoVOEstado2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.EscopoPermissaoVO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.INotificationTypeNotification), TypeInfoPropertyName = "INotificationTypeNotification2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.IProfile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.IResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.IResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.IProfileRole), TypeInfoPropertyName = "IProfileRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.ValidationMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ValidationMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.Paginacao))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.EscopoPermissaoVO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.PerfilNotificar), TypeInfoPropertyName = "PerfilNotificar2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.PerfilRole), TypeInfoPropertyName = "PerfilRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.Pessoa))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.PessoaTipoPessoa), TypeInfoPropertyName = "PessoaTipoPessoa2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.PessoaTermoId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.Recurso))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.RespostaPaginadaEmpresaPrivada))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.Perfil>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.IProfile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ValidationMessageType), TypeInfoPropertyName = "ValidationMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.EditarEmailSolicitacaoVinculoInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.SolicitarAberturaTicketInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.SolicitarAberturaTicketInputModelClassificacao), TypeInfoPropertyName = "SolicitarAberturaTicketInputModelClassificacao2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.OperationResultFailViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.TermoAceiteInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.TermoAceiteViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.CriarPessoaFisicaInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.CriarPessoaFisicaInputModelDeveNotificar), TypeInfoPropertyName = "CriarPessoaFisicaInputModelDeveNotificar2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.PessoaFisicaViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.AdicionarPerfilInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.AdicionarPerfilInputModelCargo), TypeInfoPropertyName = "AdicionarPerfilInputModelCargo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.AdicionarPerfilInputModelDeveNotificar), TypeInfoPropertyName = "AdicionarPerfilInputModelDeveNotificar2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.AdicionarRepresentanteInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.VincularOrgaoPublicoInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.AdicionarMatrizInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.RepresentanteJuridicoInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.CriarMatrizViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.DocumentoEmpresaIncorporadaInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.SolicitarEmpresaIncorporadaInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.DocumentoEmpresaIncorporadaInputModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.EmpresaIncorporadaDocumentoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.EmpresaIncorporadaSolicitacaoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.EmpresaIncorporadaDocumentoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.SolicitarVinculoColigacaoInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.AdicionarFilialInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ImportarFilialLoteInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.AdminRealizarAdesaoInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.AdministradorInforInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.MatrizInfoInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.OABInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.AtualizarPessoaFisicaInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.PessoaFisicaPDPJViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.AlterarMatrizInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.EditarRepresentanteJuridicoInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.RejeitarEmpresaIncorporadaInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ObterVinculosOrgaoPublico))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ObterVinculosOrgaoPublicoStatus), TypeInfoPropertyName = "ObterVinculosOrgaoPublicoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.Pageable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.DetalheVinculoOrgaoPublicoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.DetalheVinculoOrgaoPublicoViewModelSituacao), TypeInfoPropertyName = "DetalheVinculoOrgaoPublicoViewModelSituacao2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.RespostaPaginadaDetalheVinculoOrgaoPublicoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.DetalheVinculoOrgaoPublicoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.AudienciaViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.AudienciaViewModelFormato), TypeInfoPropertyName = "AudienciaViewModelFormato2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.AudienciaViewModelTipo), TypeInfoPropertyName = "AudienciaViewModelTipo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.PessoaViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.PessoaViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelCienciaAutomatica), TypeInfoPropertyName = "ComunicacaoProcessualViewModelCienciaAutomatica2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelFormatoSessaojulgamento), TypeInfoPropertyName = "ComunicacaoProcessualViewModelFormatoSessaojulgamento2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelInstancia), TypeInfoPropertyName = "ComunicacaoProcessualViewModelInstancia2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelMeioEnvio), TypeInfoPropertyName = "ComunicacaoProcessualViewModelMeioEnvio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelNivelSigilo), TypeInfoPropertyName = "ComunicacaoProcessualViewModelNivelSigilo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelParteInteressada), TypeInfoPropertyName = "ComunicacaoProcessualViewModelParteInteressada2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.PeticaoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.RepresentanteViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.RepresentanteViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ServidorViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelStatus), TypeInfoPropertyName = "ComunicacaoProcessualViewModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelTipoAcao), TypeInfoPropertyName = "ComunicacaoProcessualViewModelTipoAcao2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelTipoComunicacao), TypeInfoPropertyName = "ComunicacaoProcessualViewModelTipoComunicacao2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelTipoIntimacao), TypeInfoPropertyName = "ComunicacaoProcessualViewModelTipoIntimacao2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelTipoPrazo), TypeInfoPropertyName = "ComunicacaoProcessualViewModelTipoPrazo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelTipoSessaojulgamento), TypeInfoPropertyName = "ComunicacaoProcessualViewModelTipoSessaojulgamento2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.PessoaViewModelTipoDocumento), TypeInfoPropertyName = "PessoaViewModelTipoDocumento2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.RepresentanteViewModelStatus), TypeInfoPropertyName = "RepresentanteViewModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.RepresentanteViewModelTipoDocumento), TypeInfoPropertyName = "RepresentanteViewModelTipoDocumento2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoLogModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.RespostaPaginadaComunicacaoLogModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoLogModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ObterTicketViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ObterTicketViewModelClassificacao), TypeInfoPropertyName = "ObterTicketViewModelClassificacao2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ObterTicketViewModelStatus), TypeInfoPropertyName = "ObterTicketViewModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.PessoaInfoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.PessoaInfoViewModelTipoPessoa), TypeInfoPropertyName = "PessoaInfoViewModelTipoPessoa2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.TermoAceitoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.PessoaHabilitadaViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.SpecificationEmpresaPrivada))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.AtividadeEconomicaViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.EnderecoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.NaturezaJuridicaViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.PessoaJuridicaViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.RepresentanteJuridicoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.RespostaPaginadaPessoaJuridicaViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.PessoaJuridicaViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.SpecificationPessoaFisica))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.PessoaFisicaSimplesViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.RespostaPaginadaPessoaFisicaSimplesViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.PessoaFisicaSimplesViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.GestorViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.GestorViewModelCargo), TypeInfoPropertyName = "GestorViewModelCargo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ListarPerfilViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.RespostaPaginadaListarPerfilViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.ListarPerfilViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.CargoPerfilViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.EscopoPermissaoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.PerfilViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.EscopoPermissaoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.RecursosViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.RecursosViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.OrgaoPublicoRepresentanteViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.OrgaoPublicoRepresentanteViewModelSituacao), TypeInfoPropertyName = "OrgaoPublicoRepresentanteViewModelSituacao2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.RespostaPaginadaOrgaoPublicoRepresentanteViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.OrgaoPublicoRepresentanteViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ColigadaNotificacaoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.EmpresaIncorporadaVinculoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.RespostaPaginadaEmpresaIncorporadaVinculoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.EmpresaIncorporadaVinculoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.RespostaPaginadaEmpresaIncorporadaSolicitacaoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.EmpresaIncorporadaSolicitacaoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ColigadasPessoaJuridicaViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.RespostaPaginadaColigadasPessoaJuridicaViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.ColigadasPessoaJuridicaViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.DetalhesSolicitacaoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.SolicitacaoVinculoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.FilialViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.RespostaPaginadaFilialViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.FilialViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.DetalhesColigadaViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.FiliaisMatrizPorBCnpjViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.FilialBCnpjViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.FilialBCnpjViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.PaginaUsuarioPessoaJuridicaViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.RespostaPaginadaPaginaUsuarioPessoaJuridicaViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.PaginaUsuarioPessoaJuridicaViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.PessoaPerfilViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.PessoaPerfilViewModelStatusCadastro), TypeInfoPropertyName = "PessoaPerfilViewModelStatusCadastro2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.UsuarioPerfilViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.PerfilViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.UsuarioTermoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.RespostaPaginadaComunicacaoProcessualViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.PessoaProcessualOrgaoPublicoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.PessoaProcessualOrgaoPublicoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelCienciaAutomatica), TypeInfoPropertyName = "ComunicacaoProcessualOrgaoPublicoViewModelCienciaAutomatica2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelFormatoSessaojulgamento), TypeInfoPropertyName = "ComunicacaoProcessualOrgaoPublicoViewModelFormatoSessaojulgamento2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelInstancia), TypeInfoPropertyName = "ComunicacaoProcessualOrgaoPublicoViewModelInstancia2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelMeioEnvio), TypeInfoPropertyName = "ComunicacaoProcessualOrgaoPublicoViewModelMeioEnvio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelNivelSigilo), TypeInfoPropertyName = "ComunicacaoProcessualOrgaoPublicoViewModelNivelSigilo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelParteInteressada), TypeInfoPropertyName = "ComunicacaoProcessualOrgaoPublicoViewModelParteInteressada2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelRamoJustica), TypeInfoPropertyName = "ComunicacaoProcessualOrgaoPublicoViewModelRamoJustica2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelStatus), TypeInfoPropertyName = "ComunicacaoProcessualOrgaoPublicoViewModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelTipoAcao), TypeInfoPropertyName = "ComunicacaoProcessualOrgaoPublicoViewModelTipoAcao2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelTipoComunicacao), TypeInfoPropertyName = "ComunicacaoProcessualOrgaoPublicoViewModelTipoComunicacao2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelTipoIntimacao), TypeInfoPropertyName = "ComunicacaoProcessualOrgaoPublicoViewModelTipoIntimacao2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelTipoPrazo), TypeInfoPropertyName = "ComunicacaoProcessualOrgaoPublicoViewModelTipoPrazo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelTipoSessaojulgamento), TypeInfoPropertyName = "ComunicacaoProcessualOrgaoPublicoViewModelTipoSessaojulgamento2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.PessoaRelacionadaViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.PessoaRelacionadaViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.PessoaProcessualOrgaoPublicoViewModelTipoDocumento), TypeInfoPropertyName = "PessoaProcessualOrgaoPublicoViewModelTipoDocumento2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.PessoaRelacionadaViewModelTipoDocumento), TypeInfoPropertyName = "PessoaRelacionadaViewModelTipoDocumento2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.RespostaPaginadaComunicacaoProcessualOrgaoPublicoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ColigandaViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.EmpresaIncorporadaDocumentoCnpjViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.Mensagem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.MensagemTipoMensagem), TypeInfoPropertyName = "MensagemTipoMensagem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.RespostaString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.Mensagem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ResponseBoolean))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.CriarSolicitacaoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ListarCargo), TypeInfoPropertyName = "ListarCargo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesTipoComunicacao), TypeInfoPropertyName = "ObterComunicacoesTipoComunicacao2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesStatusCiente), TypeInfoPropertyName = "ObterComunicacoesStatusCiente2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesParteInteressada), TypeInfoPropertyName = "ObterComunicacoesParteInteressada2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesModalidadeComunicacaoProcessual), TypeInfoPropertyName = "ObterComunicacoesModalidadeComunicacaoProcessual2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesOrgaoPublicoTipoComunicacao), TypeInfoPropertyName = "ObterComunicacoesOrgaoPublicoTipoComunicacao2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesOrgaoPublicoStatusCiente), TypeInfoPropertyName = "ObterComunicacoesOrgaoPublicoStatusCiente2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesOrgaoPublicoParteInteressada), TypeInfoPropertyName = "ObterComunicacoesOrgaoPublicoParteInteressada2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesOrgaoPublicoRamoJustica), TypeInfoPropertyName = "ObterComunicacoesOrgaoPublicoRamoJustica2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesOrgaoPublicoModalidadeComunicacaoProcessual), TypeInfoPropertyName = "ObterComunicacoesOrgaoPublicoModalidadeComunicacaoProcessual2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ListarComunicacaoTipoComunicacao), TypeInfoPropertyName = "ListarComunicacaoTipoComunicacao2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ListarComunicacaoCiente), TypeInfoPropertyName = "ListarComunicacaoCiente2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ListarComunicacaoParteInteressada), TypeInfoPropertyName = "ListarComunicacaoParteInteressada2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.Dje.Sdk.ListarComunicacaoModalidadeComunicacaoProcessual), TypeInfoPropertyName = "ListarComunicacaoModalidadeComunicacaoProcessual2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.TermoAceitoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.ColigadaNotificacaoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.ColigandaViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.EmpresaIncorporadaDocumentoCnpjViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.EscopoPermissaoInputModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.INotification>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.RecursoCargo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.EmpresaPrivada>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.SolicitacaoVinculo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.ITermoAceite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.PessoaTermo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.IResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.ValidationMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.EscopoPermissaoVO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.Perfil>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.IProfile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.DocumentoEmpresaIncorporadaInputModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.EmpresaIncorporadaDocumentoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.DetalheVinculoOrgaoPublicoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.PessoaViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.RepresentanteViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoLogModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.PessoaJuridicaViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.PessoaFisicaSimplesViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.ListarPerfilViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.EscopoPermissaoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.RecursosViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.OrgaoPublicoRepresentanteViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.EmpresaIncorporadaVinculoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.EmpresaIncorporadaSolicitacaoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.ColigadasPessoaJuridicaViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.FilialViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.FilialBCnpjViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.PaginaUsuarioPessoaJuridicaViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.PerfilViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.PessoaProcessualOrgaoPublicoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.PessoaRelacionadaViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.Mensagem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.TermoAceitoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.ColigadaNotificacaoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.ColigandaViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Softplan.Soft.Suite.Dje.Sdk.EmpresaIncorporadaDocumentoCnpjViewModel>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}