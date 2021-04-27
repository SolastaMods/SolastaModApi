using SolastaModApi.Infrastructure;
using UnityEngine;

namespace SolastaModApi
{
    public static class ActionTypeDefinitionExtensions
    {
        public static T SetColor<T>(this T definition, Color value)
            where T : ActionTypeDefinition
        {
            definition.SetField("color", value);
            return definition;
        }

        public static T SetUnavailableColor<T>(this T definition, Color value)
            where T : ActionTypeDefinition
        {
            definition.SetField("unavailableColor", value);
            return definition;
        }
    }
}