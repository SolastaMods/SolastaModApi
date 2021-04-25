using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionCharacterPresentationExtensions
    {
        public static FeatureDefinitionCharacterPresentation SetForcedBeard(this FeatureDefinitionCharacterPresentation definition, string value)
        {
            definition.SetField("forcedBeard", value);
            return definition;
        }

        public static FeatureDefinitionCharacterPresentation SetKeepExistingBeardList(this FeatureDefinitionCharacterPresentation definition, string[] value)
        {
            definition.SetField("keepExistingBeardList", value);
            return definition;
        }

        public static FeatureDefinitionCharacterPresentation SetOccurencePercentage(this FeatureDefinitionCharacterPresentation definition, int value)
        {
            definition.SetField("occurencePercentage", value);
            return definition;
        }
    }
}