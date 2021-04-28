using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatureDefinitionSubclassChoiceExtensions
    {
        public static T SetFilterByDeity<T>(this T entity, bool value)
            where T : FeatureDefinitionSubclassChoice
        {
            entity.SetField("filterByDeity", value);
            return entity;
        }

        public static T SetSubclassSuffix<T>(this T entity, string value)
            where T : FeatureDefinitionSubclassChoice
        {
            entity.SetField("subclassSuffix", value);
            return entity;
        }
    }
}