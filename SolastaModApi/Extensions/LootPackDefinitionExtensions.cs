using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class LootPackDefinitionExtensions
    {
        public static T SetInDungeonEditor<T>(this T entity, bool value)
            where T : LootPackDefinition
        {
            entity.SetField("inDungeonEditor", value);
            return entity;
        }

        public static T SetLootChallengeMode<T>(this T entity, LootPackDefinition.LootChallenge value)
            where T : LootPackDefinition
        {
            entity.SetField("lootChallengeMode", value);
            return entity;
        }

        public static T SetLootMagnitudeMode<T>(this T entity, LootPackDefinition.LootMagnitude value)
            where T : LootPackDefinition
        {
            entity.SetField("lootMagnitudeMode", value);
            return entity;
        }

        public static T SetLootSpawnMode<T>(this T entity, LootPackDefinition.LootSpawn value)
            where T : LootPackDefinition
        {
            entity.SetField("lootSpawnMode", value);
            return entity;
        }
    }
}