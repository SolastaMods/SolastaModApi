using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatureDefinitionLoreExpertiseExtensions
    {
        public static T SetExpertiseType<T>(this T definition, FeatureDefinitionLoreExpertise.ExpertiseType value)
            where T : FeatureDefinitionLoreExpertise
        {
            definition.SetField("expertiseType", value);
            return definition;
        }
    }
}