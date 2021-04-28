using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatureDefinitionLanguageAffinityExtensions
    {
        public static T SetUniversalReader<T>(this T entity, bool value)
            where T : FeatureDefinitionLanguageAffinity
        {
            entity.SetField("universalReader", value);
            return entity;
        }
    }
}