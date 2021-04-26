using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class StageDefinitionExtensions
    {
        public static T SetAddAudioCharacter<T>(this T definition, bool value)
            where T : StageDefinition
        {
            definition.SetField("addAudioCharacter", value);
            return definition;
        }

        public static T SetGraphicsCharacterType<T>(this T definition, GraphicsCharacterDefinitions.CharacterType value)
            where T : StageDefinition
        {
            definition.SetField("graphicsCharacterType", value);
            return definition;
        }

        public static T SetViewport<T>(this T definition, StageDefinition.ViewportMode value)
            where T : StageDefinition
        {
            definition.SetField("viewport", value);
            return definition;
        }
    }
}