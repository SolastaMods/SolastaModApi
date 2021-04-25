using SolastaModApi.Infrastructure;
using UnityEngine;
using System;
using System.Collections.Generic;
using static BaseBlueprint;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class BaseBlueprintExtensions
    {
        public static void SetCategory(this BaseBlueprint definition, String value)
        {
            definition.SetField("category", value);
        }

        public static void SetDimensions(this BaseBlueprint definition, Vector2Int value)
        {
            definition.SetField("dimensions", value);
        }

        public static void SetPrefabsByEnvironment(this BaseBlueprint definition, List<PrefabByEnvironmentDescription> value)
        {
            definition.SetField("prefabsByEnvironment", value);
        }
    }
}