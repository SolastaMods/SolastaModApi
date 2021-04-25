using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class DieTypeDefinitionExtensions
    {
        public static DieTypeDefinition SetDieType(this DieTypeDefinition definition, DieType value)
        {
            definition.SetField("dieType", value);
            return definition;
        }

        public static DieTypeDefinition SetRollingMeshReference(this DieTypeDefinition definition, AssetReference value)
        {
            definition.SetField("rollingMeshReference", value);
            return definition;
        }

        public static DieTypeDefinition SetScaleFactor(this DieTypeDefinition definition, float value)
        {
            definition.SetField("scaleFactor", value);
            return definition;
        }
    }
}