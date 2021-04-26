using SolastaModApi.Infrastructure;
using static ActionDefinitions;
using static CursorDefinitions;
using static AnimationDefinitions;

namespace SolastaModApi
{
    public static class CharacterInteractionDefinitionExtensions
    {
        public static T SetActionId<T>(this T definition, Id value)
            where T : CharacterInteractionDefinition
        {
            definition.SetField("actionId", value);
            return definition;
        }

        public static T SetAnimation<T>(this T definition, ManipulationType value)
            where T : CharacterInteractionDefinition
        {
            definition.SetField("animation", value);
            return definition;
        }

        public static T SetCursorType<T>(this T definition, CursorType value)
            where T : CharacterInteractionDefinition
        {
            definition.SetField("cursorType", value);
            return definition;
        }
    }
}