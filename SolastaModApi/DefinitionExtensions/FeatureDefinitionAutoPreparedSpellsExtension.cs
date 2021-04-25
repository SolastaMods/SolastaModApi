using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionAutoPreparedSpellsExtensions
    {
        public static void SetAutoPreparedSpellsGroups(this FeatureDefinitionAutoPreparedSpells definition, List<FeatureDefinitionAutoPreparedSpells.AutoPreparedSpellsGroup> value)
        {
            definition.SetField("autoPreparedSpellsGroups", value);
        }

        public static void SetSpellcastingClass(this FeatureDefinitionAutoPreparedSpells definition, CharacterClassDefinition value)
        {
            definition.SetField("spellcastingClass", value);
        }
    }
}