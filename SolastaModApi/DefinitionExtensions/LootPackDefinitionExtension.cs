using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class LootPackDefinitionExtensions
    {
        public static LootPackDefinition SetInDungeonEditor(this LootPackDefinition definition, bool value)
        {
            definition.SetField("inDungeonEditor", value);
            return definition;
        }

        public static LootPackDefinition SetItemOccurencesList(this LootPackDefinition definition, List<ItemOccurence> value)
        {
            definition.SetField("itemOccurencesList", value);
            return definition;
        }

        public static LootPackDefinition SetLootChallengeMode(this LootPackDefinition definition, LootPackDefinition.LootChallenge value)
        {
            definition.SetField("lootChallengeMode", value);
            return definition;
        }

        public static LootPackDefinition SetLootMagnitudeMode(this LootPackDefinition definition, LootPackDefinition.LootMagnitude value)
        {
            definition.SetField("lootMagnitudeMode", value);
            return definition;
        }

        public static LootPackDefinition SetLootSpawnMode(this LootPackDefinition definition, LootPackDefinition.LootSpawn value)
        {
            definition.SetField("lootSpawnMode", value);
            return definition;
        }
    }
}