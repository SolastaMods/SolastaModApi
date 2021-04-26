using SolastaModApi.Infrastructure;
using System.Collections.Generic;

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

        public static T SetSpellsByLevel<T>(this T definition, List<SpellListDefinition.SpellsByLevelDuplet> value)
            where T : SpellListDefinition
        {
            definition.SetField("spellsByLevel", value);
            return definition;
        }
    }
}