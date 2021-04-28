using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class StageDefinitionExtensions
    {
        public static T SetAddAudioCharacter<T>(this T entity, bool value)
            where T : StageDefinition
        {
            entity.SetField("addAudioCharacter", value);
            return entity;
        }

        public static T SetGraphicsCharacterType<T>(this T entity, GraphicsCharacterDefinitions.CharacterType value)
            where T : StageDefinition
        {
            entity.SetField("graphicsCharacterType", value);
            return entity;
        }

        public static T SetViewport<T>(this T entity, StageDefinition.ViewportMode value)
            where T : StageDefinition
        {
            entity.SetField("viewport", value);
            return entity;
        }
    }
}