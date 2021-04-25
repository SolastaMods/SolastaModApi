using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionLoreExpertiseExtensions
    {
        public static FeatureDefinitionLoreExpertise SetExpertiseType(this FeatureDefinitionLoreExpertise definition, FeatureDefinitionLoreExpertise.ExpertiseType value)
        {
            definition.SetField("expertiseType", value);
            return definition;
        }
    }
}