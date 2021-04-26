using SolastaModApi.Infrastructure;
using UnityEngine;

namespace SolastaModApi
{
    public static class NotificationDefinitionExtensions
    {
        public static T SetContextualImageSize<T>(this T definition, Vector2 value)
            where T : NotificationDefinition
        {
            definition.SetField("contextualImageSize", value);
            return definition;
        }

        public static T SetDisplayType<T>(this T definition, NotificationDefinitions.DisplayType value)
            where T : NotificationDefinition
        {
            definition.SetField("displayType", value);
            return definition;
        }
    }
}