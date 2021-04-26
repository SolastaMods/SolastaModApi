using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatureDefinitionTerrainTypeAffinityExtensions
    {
        public static T SetFoodYieldMultiplier<T>(this T definition, float value)
            where T : FeatureDefinitionTerrainTypeAffinity
        {
            definition.SetField("foodYieldMultiplier", value);
            return definition;
        }

        public static T SetIgnoreTravelPacePerceptionMalus<T>(this T definition, bool value)
            where T : FeatureDefinitionTerrainTypeAffinity
        {
            definition.SetField("ignoreTravelPacePerceptionMalus", value);
            return definition;
        }

        public static T SetIngredientYieldMultiplier<T>(this T definition, float value)
            where T : FeatureDefinitionTerrainTypeAffinity
        {
            definition.SetField("ingredientYieldMultiplier", value);
            return definition;
        }

        public static T SetTerrainType<T>(this T definition, string value)
            where T : FeatureDefinitionTerrainTypeAffinity
        {
            definition.SetField("terrainType", value);
            return definition;
        }

        public static T SetTravelSpeedMultiplier<T>(this T definition, float value)
            where T : FeatureDefinitionTerrainTypeAffinity
        {
            definition.SetField("travelSpeedMultiplier", value);
            return definition;
        }
    }
}