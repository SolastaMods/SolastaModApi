using SolastaModApi.Infrastructure;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionEquipmentAffinityExtensions
    {
        public static void SetAdditionalCarryingCapacity(this FeatureDefinitionEquipmentAffinity definition, Single value)
        {
            definition.SetField("additionalCarryingCapacity", value);
        }

        public static void SetCarryingCapacityMultiplier(this FeatureDefinitionEquipmentAffinity definition, Single value)
        {
            definition.SetField("carryingCapacityMultiplier", value);
        }
    }
}