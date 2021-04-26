using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class FeatureDefinitionAutoPreparedSpellsExtensions
    {
        public static T SetAutoPreparedSpellsGroups<T>(this T definition, List<FeatureDefinitionAutoPreparedSpells.AutoPreparedSpellsGroup> value)
            where T : FeatureDefinitionAutoPreparedSpells
        {
            definition.SetField("autoPreparedSpellsGroups", value);
            return definition;
        }

        public static T SetSpellcastingClass<T>(this T definition, CharacterClassDefinition value)
            where T : FeatureDefinitionAutoPreparedSpells
        {
            definition.SetField("spellcastingClass", value);
            return definition;
        }
    }
}