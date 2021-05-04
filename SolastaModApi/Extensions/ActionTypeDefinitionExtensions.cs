using SolastaModApi.Infrastructure;
using UnityEngine;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class ActionTypeDefinitionExtensions
    {
        public static T SetColor<T>(this T entity, Color value)
            where T : ActionTypeDefinition
        {
            entity.SetField("color", value);
            return entity;
        }

        public static T SetUnavailableColor<T>(this T entity, Color value)
            where T : ActionTypeDefinition
        {
            entity.SetField("unavailableColor", value);
            return entity;
        }
    }
}