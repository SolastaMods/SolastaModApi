using SolastaModApi.Infrastructure;
using UnityEngine;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FurnitureBlueprintExtensions
    {
        public static FurnitureBlueprint SetGroundPlacement(this FurnitureBlueprint definition, bool value)
        {
            definition.SetField("groundPlacement", value);
            return definition;
        }

        public static FurnitureBlueprint SetLightSources(this FurnitureBlueprint definition, List<Vector2> value)
        {
            definition.SetField("lightSources", value);
            return definition;
        }

        public static FurnitureBlueprint SetOpeningPlacement(this FurnitureBlueprint definition, bool value)
        {
            definition.SetField("openingPlacement", value);
            return definition;
        }

        public static FurnitureBlueprint SetPropPlacement(this FurnitureBlueprint definition, bool value)
        {
            definition.SetField("propPlacement", value);
            return definition;
        }

        public static FurnitureBlueprint SetWallPlacement(this FurnitureBlueprint definition, bool value)
        {
            definition.SetField("wallPlacement", value);
            return definition;
        }
    }
}