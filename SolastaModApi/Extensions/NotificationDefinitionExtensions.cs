using SolastaModApi.Infrastructure;
using UnityEngine;

namespace SolastaModApi
{
    public static class NotificationDefinitionExtensions
    {
        public static T SetContextualImageSize<T>(this T entity, Vector2 value)
            where T : NotificationDefinition
        {
            entity.SetField("contextualImageSize", value);
            return entity;
        }

        public static T SetDisplayType<T>(this T entity, NotificationDefinitions.DisplayType value)
            where T : NotificationDefinition
        {
            entity.SetField("displayType", value);
            return entity;
        }
    }
}