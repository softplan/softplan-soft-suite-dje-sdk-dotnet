
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Se deve adicionar o escopo de permissão para todos os perfis.<br/>
    /// Example: true
    /// </summary>
    public enum AtualizarPerfilInputModelHabilitarTodos
    {
        /// <summary>
        ///
        /// </summary>
        False,
        /// <summary>
        ///
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AtualizarPerfilInputModelHabilitarTodosExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AtualizarPerfilInputModelHabilitarTodos value)
        {
            return value switch
            {
                AtualizarPerfilInputModelHabilitarTodos.False => "false",
                AtualizarPerfilInputModelHabilitarTodos.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AtualizarPerfilInputModelHabilitarTodos? ToEnum(string value)
        {
            return value switch
            {
                "false" => AtualizarPerfilInputModelHabilitarTodos.False,
                "true" => AtualizarPerfilInputModelHabilitarTodos.True,
                _ => null,
            };
        }
    }
}