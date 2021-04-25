using SolastaModApi.Infrastructure;
using static ActionDefinitions;
using static CursorDefinitions;
using static AnimationDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class CharacterInteractionDefinitionExtensions
    {
        public static void SetActionId(this CharacterInteractionDefinition definition, Id value)
        {
            definition.SetField("actionId", value);
        }

        public static void SetAnimation(this CharacterInteractionDefinition definition, ManipulationType value)
        {
            definition.SetField("animation", value);
        }

        public static void SetCursorType(this CharacterInteractionDefinition definition, CursorType value)
        {
            definition.SetField("cursorType", value);
        }
    }
}