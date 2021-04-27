using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatureDefinitionSubclassChoiceExtensions
    {
        public static T SetFilterByDeity<T>(this T definition, bool value)
            where T : FeatureDefinitionSubclassChoice
        {
            definition.SetField("filterByDeity", value);
            return definition;
        }

        public static T SetSubclassSuffix<T>(this T definition, string value)
            where T : FeatureDefinitionSubclassChoice
        {
            definition.SetField("subclassSuffix", value);
            return definition;
        }
    }
}