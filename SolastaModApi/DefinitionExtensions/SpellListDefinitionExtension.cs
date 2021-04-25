using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class SpellListDefinitionExtensions
    {
        public static void SetHasCantrips(this SpellListDefinition definition, Boolean value)
        {
            definition.SetField("hasCantrips", value);
        }

        public static void SetMaxSpellLevel(this SpellListDefinition definition, Int32 value)
        {
            definition.SetField("maxSpellLevel", value);
        }

        public static void SetSpellsByLevel(this SpellListDefinition definition, List<SpellListDefinition.SpellsByLevelDuplet> value)
        {
            definition.SetField("spellsByLevel", value);
        }
    }
}