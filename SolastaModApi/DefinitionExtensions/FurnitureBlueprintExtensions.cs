using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FurnitureBlueprintExtensions
    {
        public static T SetGroundPlacement<T>(this T definition, bool value)
            where T : FurnitureBlueprint
        {
            definition.SetField("groundPlacement", value);
            return definition;
        }

        public static T SetOpeningPlacement<T>(this T definition, bool value)
            where T : FurnitureBlueprint
        {
            definition.SetField("openingPlacement", value);
            return definition;
        }

        public static T SetPropPlacement<T>(this T definition, bool value)
            where T : FurnitureBlueprint
        {
            definition.SetField("propPlacement", value);
            return definition;
        }

        public static T SetWallPlacement<T>(this T definition, bool value)
            where T : FurnitureBlueprint
        {
            definition.SetField("wallPlacement", value);
            return definition;
        }
    }
}