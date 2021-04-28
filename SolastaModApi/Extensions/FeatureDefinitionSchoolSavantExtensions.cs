using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatureDefinitionSchoolSavantExtensions
    {
        public static T SetReductionFactor<T>(this T entity, float value)
            where T : FeatureDefinitionSchoolSavant
        {
            entity.SetField("reductionFactor", value);
            return entity;
        }

        public static T SetSchoolOfMagic<T>(this T entity, string value)
            where T : FeatureDefinitionSchoolSavant
        {
            entity.SetField("schoolOfMagic", value);
            return entity;
        }
    }
}