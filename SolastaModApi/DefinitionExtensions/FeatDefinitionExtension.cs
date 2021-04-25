using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatDefinitionExtensions
    {
        public static FeatDefinition SetArmorProficiencyCategory(this FeatDefinition definition, string value)
        {
            definition.SetField("armorProficiencyCategory", value);
            return definition;
        }

        public static FeatDefinition SetArmorProficiencyPrerequisite(this FeatDefinition definition, bool value)
        {
            definition.SetField("armorProficiencyPrerequisite", value);
            return definition;
        }

        public static FeatDefinition SetCompatibleClassesPrerequisite(this FeatDefinition definition, List<string> value)
        {
            definition.SetField("compatibleClassesPrerequisite", value);
            return definition;
        }

        public static FeatDefinition SetCompatibleRacesPrerequisite(this FeatDefinition definition, List<string> value)
        {
            definition.SetField("compatibleRacesPrerequisite", value);
            return definition;
        }

        public static FeatDefinition SetFeatures(this FeatDefinition definition, List<FeatureDefinition> value)
        {
            definition.SetField("features", value);
            return definition;
        }

        public static FeatDefinition SetKnownFeatsPrerequisite(this FeatDefinition definition, List<string> value)
        {
            definition.SetField("knownFeatsPrerequisite", value);
            return definition;
        }

        public static FeatDefinition SetMinimalAbilityScoreName(this FeatDefinition definition, string value)
        {
            definition.SetField("minimalAbilityScoreName", value);
            return definition;
        }

        public static FeatDefinition SetMinimalAbilityScorePrerequisite(this FeatDefinition definition, bool value)
        {
            definition.SetField("minimalAbilityScorePrerequisite", value);
            return definition;
        }

        public static FeatDefinition SetMinimalAbilityScoreValue(this FeatDefinition definition, int value)
        {
            definition.SetField("minimalAbilityScoreValue", value);
            return definition;
        }

        public static FeatDefinition SetMustCastSpellsPrerequisite(this FeatDefinition definition, bool value)
        {
            definition.SetField("mustCastSpellsPrerequisite", value);
            return definition;
        }
    }
}