using SolastaModApi.Infrastructure;
using UnityEngine;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class EnvironmentDefinitionExtensions
    {
        public static EnvironmentDefinition SetDimensions(this EnvironmentDefinition definition, Vector2Int value)
        {
            definition.SetField("dimensions", value);
            return definition;
        }

        public static EnvironmentDefinition SetHasFixedDimensions(this EnvironmentDefinition definition, bool value)
        {
            definition.SetField("hasFixedDimensions", value);
            return definition;
        }
    }
}