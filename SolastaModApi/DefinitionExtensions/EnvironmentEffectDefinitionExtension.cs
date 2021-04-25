using SolastaModApi.Infrastructure;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class EnvironmentEffectDefinitionExtensions
    {
        public static void SetEffectDescription(this EnvironmentEffectDefinition definition, EffectDescription value)
        {
            definition.SetField("effectDescription", value);
        }

        public static void SetInDungeonEditor(this EnvironmentEffectDefinition definition, Boolean value)
        {
            definition.SetField("inDungeonEditor", value);
        }
    }
}