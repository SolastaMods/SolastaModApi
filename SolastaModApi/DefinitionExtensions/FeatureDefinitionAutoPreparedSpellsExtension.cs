using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionAutoPreparedSpellsExtensions
    {
        public static FeatureDefinitionAutoPreparedSpells SetAutoPreparedSpellsGroups(this FeatureDefinitionAutoPreparedSpells definition, List<FeatureDefinitionAutoPreparedSpells.AutoPreparedSpellsGroup> value)
        {
            definition.SetField("autoPreparedSpellsGroups", value);
            return definition;
        }

        public static FeatureDefinitionAutoPreparedSpells SetSpellcastingClass(this FeatureDefinitionAutoPreparedSpells definition, CharacterClassDefinition value)
        {
            definition.SetField("spellcastingClass", value);
            return definition;
        }
    }
}