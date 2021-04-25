using SolastaModApi.Infrastructure;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class StageDefinitionExtensions
    {
        public static void SetAddAudioCharacter(this StageDefinition definition, Boolean value)
        {
            definition.SetField("addAudioCharacter", value);
        }

        public static void SetGraphicsCharacterType(this StageDefinition definition, GraphicsCharacterDefinitions.CharacterType value)
        {
            definition.SetField("graphicsCharacterType", value);
        }

        public static void SetViewport(this StageDefinition definition, StageDefinition.ViewportMode value)
        {
            definition.SetField("viewport", value);
        }
    }
}