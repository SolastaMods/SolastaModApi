using SolastaModApi.Infrastructure;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class ArmorCategoryDefinitionExtensions
    {
        public static void SetForbidsNegativeDexterityBonus(this ArmorCategoryDefinition definition, Boolean value)
        {
            definition.SetField("forbidsNegativeDexterityBonus", value);
        }

        public static void SetIsPhysicalArmor(this ArmorCategoryDefinition definition, Boolean value)
        {
            definition.SetField("isPhysicalArmor", value);
        }

        public static void SetNoiseRangeIfNotStealthProficient(this ArmorCategoryDefinition definition, Int32 value)
        {
            definition.SetField("noiseRangeIfNotStealthProficient", value);
        }

        public static void SetNoiseRangeIfStealthProficient(this ArmorCategoryDefinition definition, Int32 value)
        {
            definition.SetField("noiseRangeIfStealthProficient", value);
        }

        public static void SetRequiresProficiency(this ArmorCategoryDefinition definition, Boolean value)
        {
            definition.SetField("requiresProficiency", value);
        }
    }
}