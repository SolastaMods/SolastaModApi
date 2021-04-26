using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class FactionDefinitionExtensions
    {
        public static T SetBuiltIn<T>(this T definition, bool value)
            where T : FactionDefinition
        {
            definition.SetField("builtIn", value);
            return definition;
        }

        public static T SetMaxRelationCap<T>(this T definition, int value)
            where T : FactionDefinition
        {
            definition.SetField("maxRelationCap", value);
            return definition;
        }

        public static T SetMinRelationCap<T>(this T definition, int value)
            where T : FactionDefinition
        {
            definition.SetField("minRelationCap", value);
            return definition;
        }

        public static T SetProminentMembers<T>(this T definition, List<MonsterDefinition> value)
            where T : FactionDefinition
        {
            definition.SetField("prominentMembers", value);
            return definition;
        }

        public static T SetSmallSpriteReference<T>(this T definition, AssetReferenceSprite value)
            where T : FactionDefinition
        {
            definition.SetField("smallSpriteReference", value);
            return definition;
        }
    }
}