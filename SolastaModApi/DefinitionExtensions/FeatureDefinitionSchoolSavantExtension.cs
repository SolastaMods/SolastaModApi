using SolastaModApi.Infrastructure;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionSchoolSavantExtensions
    {
        public static void SetReductionFactor(this FeatureDefinitionSchoolSavant definition, Single value)
        {
            definition.SetField("reductionFactor", value);
        }

        public static void SetSchoolOfMagic(this FeatureDefinitionSchoolSavant definition, String value)
        {
            definition.SetField("schoolOfMagic", value);
        }
    }
}