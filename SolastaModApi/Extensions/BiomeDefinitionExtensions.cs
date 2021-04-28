using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class BiomeDefinitionExtensions
    {
        public static T SetEncounterTable<T>(this T entity, EncounterTableDefinition value)
            where T : BiomeDefinition
        {
            entity.SetField("encounterTable", value);
            return entity;
        }

        public static T SetTerrainType<T>(this T entity, string value)
            where T : BiomeDefinition
        {
            entity.SetField("terrainType", value);
            return entity;
        }
    }
}