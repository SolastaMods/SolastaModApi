using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class EnvironmentEffectDefinitionExtensions
    {
        public static T SetEffectDescription<T>(this T definition, EffectDescription value)
            where T : EnvironmentEffectDefinition
        {
            definition.SetField("effectDescription", value);
            return definition;
        }

        public static T SetInDungeonEditor<T>(this T definition, bool value)
            where T : EnvironmentEffectDefinition
        {
            definition.SetField("inDungeonEditor", value);
            return definition;
        }
    }
}