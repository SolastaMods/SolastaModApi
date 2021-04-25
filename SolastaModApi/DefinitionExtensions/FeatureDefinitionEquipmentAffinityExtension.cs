using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionEquipmentAffinityExtensions
    {
        public static FeatureDefinitionEquipmentAffinity SetAdditionalCarryingCapacity(this FeatureDefinitionEquipmentAffinity definition, float value)
        {
            definition.SetField("additionalCarryingCapacity", value);
            return definition;
        }

        public static FeatureDefinitionEquipmentAffinity SetCarryingCapacityMultiplier(this FeatureDefinitionEquipmentAffinity definition, float value)
        {
            definition.SetField("carryingCapacityMultiplier", value);
            return definition;
        }
    }
}