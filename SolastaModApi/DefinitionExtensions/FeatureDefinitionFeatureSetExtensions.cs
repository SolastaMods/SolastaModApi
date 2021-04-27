using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatureDefinitionFeatureSetExtensions
    {
        public static T SetDefaultSelection<T>(this T definition, int value)
            where T : FeatureDefinitionFeatureSet
        {
            definition.SetField("defaultSelection", value);
            return definition;
        }

        public static T SetEnumerateInDescription<T>(this T definition, bool value)
            where T : FeatureDefinitionFeatureSet
        {
            definition.SetField("enumerateInDescription", value);
            return definition;
        }

        public static T SetMode<T>(this T definition, FeatureDefinitionFeatureSet.FeatureSetMode value)
            where T : FeatureDefinitionFeatureSet
        {
            definition.SetField("mode", value);
            return definition;
        }

        public static T SetUniqueChoices<T>(this T definition, bool value)
            where T : FeatureDefinitionFeatureSet
        {
            definition.SetField("uniqueChoices", value);
            return definition;
        }
    }
}