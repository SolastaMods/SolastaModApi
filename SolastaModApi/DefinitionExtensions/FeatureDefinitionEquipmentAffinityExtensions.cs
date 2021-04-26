using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatureDefinitionEquipmentAffinityExtensions
    {
        public static T SetAdditionalCarryingCapacity<T>(this T definition, float value)
            where T : FeatureDefinitionEquipmentAffinity
        {
            definition.SetField("additionalCarryingCapacity", value);
            return definition;
        }

        public static T SetCarryingCapacityMultiplier<T>(this T definition, float value)
            where T : FeatureDefinitionEquipmentAffinity
        {
            definition.SetField("carryingCapacityMultiplier", value);
            return definition;
        }
    }
}