using SolastaModApi.Infrastructure;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionTerrainTypeAffinityExtensions
    {
        public static void SetFoodYieldMultiplier(this FeatureDefinitionTerrainTypeAffinity definition, Single value)
        {
            definition.SetField("foodYieldMultiplier", value);
        }

        public static void SetIgnoreTravelPacePerceptionMalus(this FeatureDefinitionTerrainTypeAffinity definition, Boolean value)
        {
            definition.SetField("ignoreTravelPacePerceptionMalus", value);
        }

        public static void SetIngredientYieldMultiplier(this FeatureDefinitionTerrainTypeAffinity definition, Single value)
        {
            definition.SetField("ingredientYieldMultiplier", value);
        }

        public static void SetTerrainType(this FeatureDefinitionTerrainTypeAffinity definition, String value)
        {
            definition.SetField("terrainType", value);
        }

        public static void SetTravelSpeedMultiplier(this FeatureDefinitionTerrainTypeAffinity definition, Single value)
        {
            definition.SetField("travelSpeedMultiplier", value);
        }
    }
}