using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class ContainerItemDescriptionExtensions
    {
        public static T SetMinSlotsNumber<T>(this T entity, int value)
            where T : ContainerItemDescription
        {
            entity.SetField("minSlotsNumber", value);
            return entity;
        }

        public static T SetPersonalContainer<T>(this T entity, bool value)
            where T : ContainerItemDescription
        {
            entity.SetField("personalContainer", value);
            return entity;
        }

        public static T SetSlotsPerRow<T>(this T entity, int value)
            where T : ContainerItemDescription
        {
            entity.SetField("slotsPerRow", value);
            return entity;
        }

        public static T SetWeightCapacity<T>(this T entity, float value)
            where T : ContainerItemDescription
        {
            entity.SetField("weightCapacity", value);
            return entity;
        }

        public static T SetWeightCapacityMultiplier<T>(this T entity, float value)
            where T : ContainerItemDescription
        {
            entity.SetField("weightCapacityMultiplier", value);
            return entity;
        }

        public static T SetWeightComputationMethod<T>(this T entity, ContainerItemDescription.WeightComputation value)
            where T : ContainerItemDescription
        {
            entity.SetField("weightComputationMethod", value);
            return entity;
        }
    }
}