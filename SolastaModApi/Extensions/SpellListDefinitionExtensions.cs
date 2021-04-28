using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class SpellListDefinitionExtensions
    {
        public static T SetHasCantrips<T>(this T entity, bool value)
            where T : SpellListDefinition
        {
            entity.SetField("hasCantrips", value);
            return entity;
        }

        public static T SetMaxSpellLevel<T>(this T entity, int value)
            where T : SpellListDefinition
        {
            entity.SetField("maxSpellLevel", value);
            return entity;
        }
    }
}