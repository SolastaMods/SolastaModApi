using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class GadgetDefinitionExtensions
    {
        public static T SetArmorClass<T>(this T entity, int value)
            where T : GadgetDefinition
        {
            entity.SetField("armorClass", value);
            return entity;
        }
    }
}