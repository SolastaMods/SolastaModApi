using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class EnvironmentEffectDefinitionExtensions
    {
        public static T SetEffectDescription<T>(this T entity, EffectDescription value)
            where T : EnvironmentEffectDefinition
        {
            entity.SetField("effectDescription", value);
            return entity;
        }

        public static T SetInDungeonEditor<T>(this T entity, bool value)
            where T : EnvironmentEffectDefinition
        {
            entity.SetField("inDungeonEditor", value);
            return entity;
        }
    }
}