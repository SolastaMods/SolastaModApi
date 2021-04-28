using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatureDefinitionEquipmentAffinityExtensions
    {
        public static T SetAdditionalCarryingCapacity<T>(this T entity, float value)
            where T : FeatureDefinitionEquipmentAffinity
        {
            entity.SetField("additionalCarryingCapacity", value);
            return entity;
        }

        public static T SetCarryingCapacityMultiplier<T>(this T entity, float value)
            where T : FeatureDefinitionEquipmentAffinity
        {
            entity.SetField("carryingCapacityMultiplier", value);
            return entity;
        }
    }
}