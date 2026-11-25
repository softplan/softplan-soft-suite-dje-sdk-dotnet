
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Se a pessoa deseja receber notificações por email<br/>
    /// Example: TODAS
    /// </summary>
    public enum CriarPessoaFisicaInputModelDeveNotificar
    {
        /// <summary>
        ///
        /// </summary>
        Nenhuma,
        /// <summary>
        ///
        /// </summary>
        Resumo,
        /// <summary>
        ///
        /// </summary>
        Todas,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CriarPessoaFisicaInputModelDeveNotificarExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CriarPessoaFisicaInputModelDeveNotificar value)
        {
            return value switch
            {
                CriarPessoaFisicaInputModelDeveNotificar.Nenhuma => "NENHUMA",
                CriarPessoaFisicaInputModelDeveNotificar.Resumo => "RESUMO",
                CriarPessoaFisicaInputModelDeveNotificar.Todas => "TODAS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CriarPessoaFisicaInputModelDeveNotificar? ToEnum(string value)
        {
            return value switch
            {
                "NENHUMA" => CriarPessoaFisicaInputModelDeveNotificar.Nenhuma,
                "RESUMO" => CriarPessoaFisicaInputModelDeveNotificar.Resumo,
                "TODAS" => CriarPessoaFisicaInputModelDeveNotificar.Todas,
                _ => null,
            };
        }
    }
}