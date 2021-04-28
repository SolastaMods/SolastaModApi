using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatureDefinitionCharacterPresentationExtensions
    {
        public static T SetForcedBeard<T>(this T entity, string value)
            where T : FeatureDefinitionCharacterPresentation
        {
            entity.SetField("forcedBeard", value);
            return entity;
        }

        public static T SetKeepExistingBeardList<T>(this T entity, string[] value)
            where T : FeatureDefinitionCharacterPresentation
        {
            entity.SetField("keepExistingBeardList", value);
            return entity;
        }

        public static T SetOccurencePercentage<T>(this T entity, int value)
            where T : FeatureDefinitionCharacterPresentation
        {
            entity.SetField("occurencePercentage", value);
            return entity;
        }
    }
}