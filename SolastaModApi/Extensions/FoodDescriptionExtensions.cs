using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FoodDescriptionExtensions
    {
        public static T SetNutritiveCapacity<T>(this T entity, int value)
            where T : FoodDescription
        {
            entity.SetField("nutritiveCapacity", value);
            return entity;
        }

        public static T SetPerishable<T>(this T entity, bool value)
            where T : FoodDescription
        {
            entity.SetField("perishable", value);
            return entity;
        }
    }
}