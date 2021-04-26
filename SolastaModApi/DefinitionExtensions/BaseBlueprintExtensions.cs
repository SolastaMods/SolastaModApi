using SolastaModApi.Infrastructure;
using UnityEngine;
using System.Collections.Generic;
using static BaseBlueprint;

namespace SolastaModApi
{
    public static class BaseBlueprintExtensions
    {
        public static T SetCategory<T>(this T definition, string value)
            where T : BaseBlueprint
        {
            definition.SetField("category", value);
            return definition;
        }

        public static T SetDimensions<T>(this T definition, Vector2Int value)
            where T : BaseBlueprint
        {
            definition.SetField("dimensions", value);
            return definition;
        }

        public static T SetPrefabsByEnvironment<T>(this T definition, List<PrefabByEnvironmentDescription> value)
            where T : BaseBlueprint
        {
            definition.SetField("prefabsByEnvironment", value);
            return definition;
        }
    }
}