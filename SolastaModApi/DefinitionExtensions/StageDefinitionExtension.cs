using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class StageDefinitionExtensions
    {
        public static StageDefinition SetAddAudioCharacter(this StageDefinition definition, bool value)
        {
            definition.SetField("addAudioCharacter", value);
            return definition;
        }

        public static StageDefinition SetGraphicsCharacterType(this StageDefinition definition, GraphicsCharacterDefinitions.CharacterType value)
        {
            definition.SetField("graphicsCharacterType", value);
            return definition;
        }

        public static StageDefinition SetViewport(this StageDefinition definition, StageDefinition.ViewportMode value)
        {
            definition.SetField("viewport", value);
            return definition;
        }
    }
}