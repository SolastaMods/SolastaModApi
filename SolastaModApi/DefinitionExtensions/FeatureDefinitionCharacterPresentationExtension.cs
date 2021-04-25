using SolastaModApi.Infrastructure;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionCharacterPresentationExtensions
    {
        public static void SetForcedBeard(this FeatureDefinitionCharacterPresentation definition, String value)
        {
            definition.SetField("forcedBeard", value);
        }

        public static void SetKeepExistingBeardList(this FeatureDefinitionCharacterPresentation definition, String[] value)
        {
            definition.SetField("keepExistingBeardList", value);
        }

        public static void SetOccurencePercentage(this FeatureDefinitionCharacterPresentation definition, Int32 value)
        {
            definition.SetField("occurencePercentage", value);
        }
    }
}