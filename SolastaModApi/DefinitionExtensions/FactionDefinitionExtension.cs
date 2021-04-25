using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FactionDefinitionExtensions
    {
        public static void SetBuiltIn(this FactionDefinition definition, Boolean value)
        {
            definition.SetField("builtIn", value);
        }

        public static void SetMaxRelationCap(this FactionDefinition definition, Int32 value)
        {
            definition.SetField("maxRelationCap", value);
        }

        public static void SetMinRelationCap(this FactionDefinition definition, Int32 value)
        {
            definition.SetField("minRelationCap", value);
        }

        public static void SetProminentMembers(this FactionDefinition definition, List<MonsterDefinition> value)
        {
            definition.SetField("prominentMembers", value);
        }

        public static void SetSmallSpriteReference(this FactionDefinition definition, AssetReferenceSprite value)
        {
            definition.SetField("smallSpriteReference", value);
        }
    }
}