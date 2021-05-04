using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
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