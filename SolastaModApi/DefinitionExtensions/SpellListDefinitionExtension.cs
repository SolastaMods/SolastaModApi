using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class SpellListDefinitionExtensions
    {
        public static SpellListDefinition SetHasCantrips(this SpellListDefinition definition, bool value)
        {
            definition.SetField("hasCantrips", value);
            return definition;
        }

        public static SpellListDefinition SetMaxSpellLevel(this SpellListDefinition definition, int value)
        {
            definition.SetField("maxSpellLevel", value);
            return definition;
        }

        public static SpellListDefinition SetSpellsByLevel(this SpellListDefinition definition, List<SpellListDefinition.SpellsByLevelDuplet> value)
        {
            definition.SetField("spellsByLevel", value);
            return definition;
        }
    }
}