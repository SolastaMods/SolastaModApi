using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatDefinitionExtensions
    {
        public static void SetArmorProficiencyCategory(this FeatDefinition definition, String value)
        {
            definition.SetField("armorProficiencyCategory", value);
        }

        public static void SetArmorProficiencyPrerequisite(this FeatDefinition definition, Boolean value)
        {
            definition.SetField("armorProficiencyPrerequisite", value);
        }

        public static void SetCompatibleClassesPrerequisite(this FeatDefinition definition, List<String> value)
        {
            definition.SetField("compatibleClassesPrerequisite", value);
        }

        public static void SetCompatibleRacesPrerequisite(this FeatDefinition definition, List<String> value)
        {
            definition.SetField("compatibleRacesPrerequisite", value);
        }

        public static void SetFeatures(this FeatDefinition definition, List<FeatureDefinition> value)
        {
            definition.SetField("features", value);
        }

        public static void SetKnownFeatsPrerequisite(this FeatDefinition definition, List<String> value)
        {
            definition.SetField("knownFeatsPrerequisite", value);
        }

        public static void SetMinimalAbilityScoreName(this FeatDefinition definition, String value)
        {
            definition.SetField("minimalAbilityScoreName", value);
        }

        public static void SetMinimalAbilityScorePrerequisite(this FeatDefinition definition, Boolean value)
        {
            definition.SetField("minimalAbilityScorePrerequisite", value);
        }

        public static void SetMinimalAbilityScoreValue(this FeatDefinition definition, Int32 value)
        {
            definition.SetField("minimalAbilityScoreValue", value);
        }

        public static void SetMustCastSpellsPrerequisite(this FeatDefinition definition, Boolean value)
        {
            definition.SetField("mustCastSpellsPrerequisite", value);
        }
    }
}