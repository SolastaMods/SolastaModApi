using SolastaModApi.Infrastructure;
using UnityEngine;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class EnvironmentDefinitionExtensions
    {
        public static void SetDimensions(this EnvironmentDefinition definition, Vector2Int value)
        {
            definition.SetField("dimensions", value);
        }

        public static void SetHasFixedDimensions(this EnvironmentDefinition definition, Boolean value)
        {
            definition.SetField("hasFixedDimensions", value);
        }
    }
}