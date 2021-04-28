using SolastaModApi.Infrastructure;
using UnityEngine;

namespace SolastaModApi
{
    public static class EnvironmentDefinitionExtensions
    {
        public static EnvironmentDefinition SetDimensions(this EnvironmentDefinition entity, Vector2Int value)
        {
            entity.SetField("dimensions", value);
            return entity;
        }

        public static EnvironmentDefinition SetHasFixedDimensions(this EnvironmentDefinition entity, bool value)
        {
            entity.SetField("hasFixedDimensions", value);
            return entity;
        }
    }
}