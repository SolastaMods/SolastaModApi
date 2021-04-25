using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionLoreExpertiseExtensions
    {
        public static void SetExpertiseType(this FeatureDefinitionLoreExpertise definition, FeatureDefinitionLoreExpertise.ExpertiseType value)
        {
            definition.SetField("expertiseType", value);
        }
    }
}