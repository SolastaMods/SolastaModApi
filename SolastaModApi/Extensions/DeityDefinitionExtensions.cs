using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class DeityDefinitionExtensions
    {
        public static T SetAlignment<T>(this T entity, string value)
            where T : DeityDefinition
        {
            entity.SetField("alignment", value);
            return entity;
        }

        public static T SetSelectableByPlayer<T>(this T entity, bool value)
            where T : DeityDefinition
        {
            entity.SetField("selectableByPlayer", value);
            return entity;
        }
    }
}