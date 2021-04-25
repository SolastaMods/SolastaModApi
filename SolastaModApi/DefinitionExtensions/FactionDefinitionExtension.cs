using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FactionDefinitionExtensions
    {
        public static FactionDefinition SetBuiltIn(this FactionDefinition definition, bool value)
        {
            definition.SetField("builtIn", value);
            return definition;
        }

        public static FactionDefinition SetMaxRelationCap(this FactionDefinition definition, int value)
        {
            definition.SetField("maxRelationCap", value);
            return definition;
        }

        public static FactionDefinition SetMinRelationCap(this FactionDefinition definition, int value)
        {
            definition.SetField("minRelationCap", value);
            return definition;
        }

        public static FactionDefinition SetProminentMembers(this FactionDefinition definition, List<MonsterDefinition> value)
        {
            definition.SetField("prominentMembers", value);
            return definition;
        }

        public static FactionDefinition SetSmallSpriteReference(this FactionDefinition definition, AssetReferenceSprite value)
        {
            definition.SetField("smallSpriteReference", value);
            return definition;
        }
    }
}