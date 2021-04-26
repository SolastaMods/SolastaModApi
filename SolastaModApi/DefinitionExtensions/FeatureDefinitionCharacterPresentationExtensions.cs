using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatureDefinitionCharacterPresentationExtensions
    {
        public static T SetForcedBeard<T>(this T definition, string value)
            where T : FeatureDefinitionCharacterPresentation
        {
            definition.SetField("forcedBeard", value);
            return definition;
        }

        public static T SetKeepExistingBeardList<T>(this T definition, string[] value)
            where T : FeatureDefinitionCharacterPresentation
        {
            definition.SetField("keepExistingBeardList", value);
            return definition;
        }

        public static T SetOccurencePercentage<T>(this T definition, int value)
            where T : FeatureDefinitionCharacterPresentation
        {
            definition.SetField("occurencePercentage", value);
            return definition;
        }
    }
}