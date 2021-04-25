using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class ArmorCategoryDefinitionExtensions
    {
        public static ArmorCategoryDefinition SetForbidsNegativeDexterityBonus(this ArmorCategoryDefinition definition, bool value)
        {
            definition.SetField("forbidsNegativeDexterityBonus", value);
            return definition;
        }

        public static ArmorCategoryDefinition SetIsPhysicalArmor(this ArmorCategoryDefinition definition, bool value)
        {
            definition.SetField("isPhysicalArmor", value);
            return definition;
        }

        public static ArmorCategoryDefinition SetNoiseRangeIfNotStealthProficient(this ArmorCategoryDefinition definition, int value)
        {
            definition.SetField("noiseRangeIfNotStealthProficient", value);
            return definition;
        }

        public static ArmorCategoryDefinition SetNoiseRangeIfStealthProficient(this ArmorCategoryDefinition definition, int value)
        {
            definition.SetField("noiseRangeIfStealthProficient", value);
            return definition;
        }

        public static ArmorCategoryDefinition SetRequiresProficiency(this ArmorCategoryDefinition definition, bool value)
        {
            definition.SetField("requiresProficiency", value);
            return definition;
        }
    }
}