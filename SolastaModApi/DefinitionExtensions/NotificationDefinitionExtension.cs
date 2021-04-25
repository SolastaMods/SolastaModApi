using SolastaModApi.Infrastructure;
using UnityEngine;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class NotificationDefinitionExtensions
    {
        public static NotificationDefinition SetContextualImageSize(this NotificationDefinition definition, Vector2 value)
        {
            definition.SetField("contextualImageSize", value);
            return definition;
        }

        public static NotificationDefinition SetDisplayType(this NotificationDefinition definition, NotificationDefinitions.DisplayType value)
        {
            definition.SetField("displayType", value);
            return definition;
        }
    }
}