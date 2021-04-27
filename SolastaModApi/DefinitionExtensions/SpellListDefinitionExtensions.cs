using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class SpellListDefinitionExtensions
    {
        public static T SetHasCantrips<T>(this T definition, bool value)
            where T : SpellListDefinition
        {
            definition.SetField("hasCantrips", value);
            return definition;
        }

        public static T SetMaxSpellLevel<T>(this T definition, int value)
            where T : SpellListDefinition
        {
            definition.SetField("maxSpellLevel", value);
            return definition;
        }
    }
}