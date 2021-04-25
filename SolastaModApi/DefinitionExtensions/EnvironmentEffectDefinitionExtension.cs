using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class EnvironmentEffectDefinitionExtensions
    {
        public static EnvironmentEffectDefinition SetEffectDescription(this EnvironmentEffectDefinition definition, EffectDescription value)
        {
            definition.SetField("effectDescription", value);
            return definition;
        }

        public static EnvironmentEffectDefinition SetInDungeonEditor(this EnvironmentEffectDefinition definition, bool value)
        {
            definition.SetField("inDungeonEditor", value);
            return definition;
        }
    }
}