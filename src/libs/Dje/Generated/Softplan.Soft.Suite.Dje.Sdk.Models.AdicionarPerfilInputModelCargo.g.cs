
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Id do cargo a ser atribuido para a pessoa.(ADMINISTRADOR_GERAL_CNJ - 1,<br/>
    /// ADMINISTRADOR_DA_EMPRESA - 2,<br/>
    /// ADMINISTRADOR_ORGAO_PUBLICO - 3,<br/>
    /// GESTOR_DE_CADASTRO_PRIVADO - 4,<br/>
    /// GESTOR_DE_CADASTRO_PUBLICO - 5,<br/>
    /// PREPOSTO_DA_COMUNICACAO_PRIVADO - 6,<br/>
    /// PREPOSTO_DA_COMUNICACAO_PUBLICO - 7)<br/>
    /// Example: 1
    /// </summary>
    public enum AdicionarPerfilInputModelCargo
    {
        /// <summary>
        ///
        /// </summary>
        x1,
        /// <summary>
        ///
        /// </summary>
        x10,
        /// <summary>
        ///
        /// </summary>
        x11,
        /// <summary>
        ///
        /// </summary>
        x2,
        /// <summary>
        ///
        /// </summary>
        x3,
        /// <summary>
        ///
        /// </summary>
        x4,
        /// <summary>
        ///
        /// </summary>
        x5,
        /// <summary>
        ///
        /// </summary>
        x6,
        /// <summary>
        ///
        /// </summary>
        x7,
        /// <summary>
        ///
        /// </summary>
        x8,
        /// <summary>
        ///
        /// </summary>
        x9,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdicionarPerfilInputModelCargoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdicionarPerfilInputModelCargo value)
        {
            return value switch
            {
                AdicionarPerfilInputModelCargo.x1 => "1",
                AdicionarPerfilInputModelCargo.x10 => "10",
                AdicionarPerfilInputModelCargo.x11 => "11",
                AdicionarPerfilInputModelCargo.x2 => "2",
                AdicionarPerfilInputModelCargo.x3 => "3",
                AdicionarPerfilInputModelCargo.x4 => "4",
                AdicionarPerfilInputModelCargo.x5 => "5",
                AdicionarPerfilInputModelCargo.x6 => "6",
                AdicionarPerfilInputModelCargo.x7 => "7",
                AdicionarPerfilInputModelCargo.x8 => "8",
                AdicionarPerfilInputModelCargo.x9 => "9",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdicionarPerfilInputModelCargo? ToEnum(string value)
        {
            return value switch
            {
                "1" => AdicionarPerfilInputModelCargo.x1,
                "10" => AdicionarPerfilInputModelCargo.x10,
                "11" => AdicionarPerfilInputModelCargo.x11,
                "2" => AdicionarPerfilInputModelCargo.x2,
                "3" => AdicionarPerfilInputModelCargo.x3,
                "4" => AdicionarPerfilInputModelCargo.x4,
                "5" => AdicionarPerfilInputModelCargo.x5,
                "6" => AdicionarPerfilInputModelCargo.x6,
                "7" => AdicionarPerfilInputModelCargo.x7,
                "8" => AdicionarPerfilInputModelCargo.x8,
                "9" => AdicionarPerfilInputModelCargo.x9,
                _ => null,
            };
        }
    }
}