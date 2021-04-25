using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionSchoolSavantExtensions
    {
        public static FeatureDefinitionSchoolSavant SetReductionFactor(this FeatureDefinitionSchoolSavant definition, float value)
        {
            definition.SetField("reductionFactor", value);
            return definition;
        }

        public static FeatureDefinitionSchoolSavant SetSchoolOfMagic(this FeatureDefinitionSchoolSavant definition, string value)
        {
            definition.SetField("schoolOfMagic", value);
            return definition;
        }
    }
}