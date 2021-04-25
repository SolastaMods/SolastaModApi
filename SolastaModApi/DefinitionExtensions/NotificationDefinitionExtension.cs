using SolastaModApi.Infrastructure;
using UnityEngine;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class NotificationDefinitionExtensions
    {
        public static void SetContextualImageSize(this NotificationDefinition definition, Vector2 value)
        {
            definition.SetField("contextualImageSize", value);
        }

        public static void SetDisplayType(this NotificationDefinition definition, NotificationDefinitions.DisplayType value)
        {
            definition.SetField("displayType", value);
        }
    }
}