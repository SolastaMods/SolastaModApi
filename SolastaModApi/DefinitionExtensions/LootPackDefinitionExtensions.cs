using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class LootPackDefinitionExtensions
    {
        public static T SetInDungeonEditor<T>(this T definition, bool value)
            where T : LootPackDefinition
        {
            definition.SetField("inDungeonEditor", value);
            return definition;
        }

        public static T SetItemOccurencesList<T>(this T definition, List<ItemOccurence> value)
            where T : LootPackDefinition
        {
            definition.SetField("itemOccurencesList", value);
            return definition;
        }

        public static T SetLootChallengeMode<T>(this T definition, LootPackDefinition.LootChallenge value)
            where T : LootPackDefinition
        {
            definition.SetField("lootChallengeMode", value);
            return definition;
        }

        public static T SetLootMagnitudeMode<T>(this T definition, LootPackDefinition.LootMagnitude value)
            where T : LootPackDefinition
        {
            definition.SetField("lootMagnitudeMode", value);
            return definition;
        }

        public static T SetLootSpawnMode<T>(this T definition, LootPackDefinition.LootSpawn value)
            where T : LootPackDefinition
        {
            definition.SetField("lootSpawnMode", value);
            return definition;
        }
    }
}