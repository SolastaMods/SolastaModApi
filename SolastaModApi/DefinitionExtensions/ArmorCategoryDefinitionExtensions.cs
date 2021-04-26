using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class ArmorCategoryDefinitionExtensions
    {
        public static T SetForbidsNegativeDexterityBonus<T>(this T definition, bool value)
            where T : ArmorCategoryDefinition
        {
            definition.SetField("forbidsNegativeDexterityBonus", value);
            return definition;
        }

        public static T SetIsPhysicalArmor<T>(this T definition, bool value)
            where T : ArmorCategoryDefinition
        {
            definition.SetField("isPhysicalArmor", value);
            return definition;
        }

        public static T SetNoiseRangeIfNotStealthProficient<T>(this T definition, int value)
            where T : ArmorCategoryDefinition
        {
            definition.SetField("noiseRangeIfNotStealthProficient", value);
            return definition;
        }

        public static T SetNoiseRangeIfStealthProficient<T>(this T definition, int value)
            where T : ArmorCategoryDefinition
        {
            definition.SetField("noiseRangeIfStealthProficient", value);
            return definition;
        }

        public static T SetRequiresProficiency<T>(this T definition, bool value)
            where T : ArmorCategoryDefinition
        {
            definition.SetField("requiresProficiency", value);
            return definition;
        }
    }
}