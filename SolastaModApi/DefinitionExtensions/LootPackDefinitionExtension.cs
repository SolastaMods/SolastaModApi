using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class LootPackDefinitionExtensions
    {
        public static void SetInDungeonEditor(this LootPackDefinition definition, Boolean value)
        {
            definition.SetField("inDungeonEditor", value);
        }

        public static void SetItemOccurencesList(this LootPackDefinition definition, List<ItemOccurence> value)
        {
            definition.SetField("itemOccurencesList", value);
        }

        public static void SetLootChallengeMode(this LootPackDefinition definition, LootPackDefinition.LootChallenge value)
        {
            definition.SetField("lootChallengeMode", value);
        }

        public static void SetLootMagnitudeMode(this LootPackDefinition definition, LootPackDefinition.LootMagnitude value)
        {
            definition.SetField("lootMagnitudeMode", value);
        }

        public static void SetLootSpawnMode(this LootPackDefinition definition, LootPackDefinition.LootSpawn value)
        {
            definition.SetField("lootSpawnMode", value);
        }
    }
}