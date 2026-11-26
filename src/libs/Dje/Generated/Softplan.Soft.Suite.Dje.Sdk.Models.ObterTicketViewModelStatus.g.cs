
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Status do ticket<br/>
    /// Example: FINALIZADO
    /// </summary>
    public enum ObterTicketViewModelStatus
    {
        /// <summary>
        ///
        /// </summary>
        Cancelado,
        /// <summary>
        ///
        /// </summary>
        Finalizado,
        /// <summary>
        ///
        /// </summary>
        Processando,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObterTicketViewModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObterTicketViewModelStatus value)
        {
            return value switch
            {
                ObterTicketViewModelStatus.Cancelado => "CANCELADO",
                ObterTicketViewModelStatus.Finalizado => "FINALIZADO",
                ObterTicketViewModelStatus.Processando => "PROCESSANDO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObterTicketViewModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELADO" => ObterTicketViewModelStatus.Cancelado,
                "FINALIZADO" => ObterTicketViewModelStatus.Finalizado,
                "PROCESSANDO" => ObterTicketViewModelStatus.Processando,
                _ => null,
            };
        }
    }
}