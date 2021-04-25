using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionTerrainTypeAffinityExtensions
    {
        public static FeatureDefinitionTerrainTypeAffinity SetFoodYieldMultiplier(this FeatureDefinitionTerrainTypeAffinity definition, float value)
        {
            definition.SetField("foodYieldMultiplier", value);
            return definition;
        }

        public static FeatureDefinitionTerrainTypeAffinity SetIgnoreTravelPacePerceptionMalus(this FeatureDefinitionTerrainTypeAffinity definition, bool value)
        {
            definition.SetField("ignoreTravelPacePerceptionMalus", value);
            return definition;
        }

        public static FeatureDefinitionTerrainTypeAffinity SetIngredientYieldMultiplier(this FeatureDefinitionTerrainTypeAffinity definition, float value)
        {
            definition.SetField("ingredientYieldMultiplier", value);
            return definition;
        }

        public static FeatureDefinitionTerrainTypeAffinity SetTerrainType(this FeatureDefinitionTerrainTypeAffinity definition, string value)
        {
            definition.SetField("terrainType", value);
            return definition;
        }

        public static FeatureDefinitionTerrainTypeAffinity SetTravelSpeedMultiplier(this FeatureDefinitionTerrainTypeAffinity definition, float value)
        {
            definition.SetField("travelSpeedMultiplier", value);
            return definition;
        }
    }
}