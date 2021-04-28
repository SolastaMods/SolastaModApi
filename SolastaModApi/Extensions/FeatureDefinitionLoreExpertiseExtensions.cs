using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatureDefinitionLoreExpertiseExtensions
    {
        public static T SetExpertiseType<T>(this T entity, FeatureDefinitionLoreExpertise.ExpertiseType value)
            where T : FeatureDefinitionLoreExpertise
        {
            entity.SetField("expertiseType", value);
            return entity;
        }
    }
}