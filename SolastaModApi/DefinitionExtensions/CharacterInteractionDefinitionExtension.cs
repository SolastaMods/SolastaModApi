using SolastaModApi.Infrastructure;
using static ActionDefinitions;
using static CursorDefinitions;
using static AnimationDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class CharacterInteractionDefinitionExtensions
    {
        public static CharacterInteractionDefinition SetActionId(this CharacterInteractionDefinition definition, Id value)
        {
            definition.SetField("actionId", value);
            return definition;
        }

        public static CharacterInteractionDefinition SetAnimation(this CharacterInteractionDefinition definition, ManipulationType value)
        {
            definition.SetField("animation", value);
            return definition;
        }

        public static CharacterInteractionDefinition SetCursorType(this CharacterInteractionDefinition definition, CursorType value)
        {
            definition.SetField("cursorType", value);
            return definition;
        }
    }
}