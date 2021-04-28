using SolastaModApi.Infrastructure;
using UnityEngine;

namespace SolastaModApi
{
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