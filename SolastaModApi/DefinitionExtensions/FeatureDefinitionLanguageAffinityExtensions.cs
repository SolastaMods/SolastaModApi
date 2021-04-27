using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatureDefinitionLanguageAffinityExtensions
    {
        public static T SetUniversalReader<T>(this T definition, bool value)
            where T : FeatureDefinitionLanguageAffinity
        {
            definition.SetField("universalReader", value);
            return definition;
        }
    }
}