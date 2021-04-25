using SolastaModApi.Infrastructure;
using UnityEngine;
using System.Collections.Generic;
using static BaseBlueprint;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class BaseBlueprintExtensions
    {
        public static BaseBlueprint SetCategory(this BaseBlueprint definition, string value)
        {
            definition.SetField("category", value);
            return definition;
        }

        public static BaseBlueprint SetDimensions(this BaseBlueprint definition, Vector2Int value)
        {
            definition.SetField("dimensions", value);
            return definition;
        }

        public static BaseBlueprint SetPrefabsByEnvironment(this BaseBlueprint definition, List<PrefabByEnvironmentDescription> value)
        {
            definition.SetField("prefabsByEnvironment", value);
            return definition;
        }
    }
}