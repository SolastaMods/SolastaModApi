using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using System;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class DieTypeDefinitionExtensions
    {
        public static void SetDieType(this DieTypeDefinition definition, DieType value)
        {
            definition.SetField("dieType", value);
        }

        public static void SetRollingMeshReference(this DieTypeDefinition definition, AssetReference value)
        {
            definition.SetField("rollingMeshReference", value);
        }

        public static void SetScaleFactor(this DieTypeDefinition definition, Single value)
        {
            definition.SetField("scaleFactor", value);
        }
    }
}