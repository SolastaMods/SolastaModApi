using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatDefinitionExtensions
    {
        public static T SetArmorProficiencyCategory<T>(this T definition, string value)
            where T : FeatDefinition
        {
            definition.SetField("armorProficiencyCategory", value);
            return definition;
        }

        public static T SetArmorProficiencyPrerequisite<T>(this T definition, bool value)
            where T : FeatDefinition
        {
            definition.SetField("armorProficiencyPrerequisite", value);
            return definition;
        }

        public static T SetMinimalAbilityScoreName<T>(this T definition, string value)
            where T : FeatDefinition
        {
            definition.SetField("minimalAbilityScoreName", value);
            return definition;
        }

        public static T SetMinimalAbilityScorePrerequisite<T>(this T definition, bool value)
            where T : FeatDefinition
        {
            definition.SetField("minimalAbilityScorePrerequisite", value);
            return definition;
        }

        public static T SetMinimalAbilityScoreValue<T>(this T definition, int value)
            where T : FeatDefinition
        {
            definition.SetField("minimalAbilityScoreValue", value);
            return definition;
        }

        public static T SetMustCastSpellsPrerequisite<T>(this T definition, bool value)
            where T : FeatDefinition
        {
            definition.SetField("mustCastSpellsPrerequisite", value);
            return definition;
        }
    }
}