using SolastaModApi.Infrastructure;
using UnityEngine;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FurnitureBlueprintExtensions
    {
        public static void SetGroundPlacement(this FurnitureBlueprint definition, Boolean value)
        {
            definition.SetField("groundPlacement", value);
        }

        public static void SetLightSources(this FurnitureBlueprint definition, List<Vector2> value)
        {
            definition.SetField("lightSources", value);
        }

        public static void SetOpeningPlacement(this FurnitureBlueprint definition, Boolean value)
        {
            definition.SetField("openingPlacement", value);
        }

        public static void SetPropPlacement(this FurnitureBlueprint definition, Boolean value)
        {
            definition.SetField("propPlacement", value);
        }

        public static void SetWallPlacement(this FurnitureBlueprint definition, Boolean value)
        {
            definition.SetField("wallPlacement", value);
        }
    }
}