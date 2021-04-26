using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatureDefinitionSchoolSavantExtensions
    {
        public static T SetReductionFactor<T>(this T definition, float value)
            where T : FeatureDefinitionSchoolSavant
        {
            definition.SetField("reductionFactor", value);
            return definition;
        }

        public static T SetSchoolOfMagic<T>(this T definition, string value)
            where T : FeatureDefinitionSchoolSavant
        {
            definition.SetField("schoolOfMagic", value);
            return definition;
        }
    }
}