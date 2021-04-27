using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class BiomeDefinitionExtensions
    {
        public static T SetEncounterTable<T>(this T definition, EncounterTableDefinition value)
            where T : BiomeDefinition
        {
            definition.SetField("encounterTable", value);
            return definition;
        }

        public static T SetTerrainType<T>(this T definition, string value)
            where T : BiomeDefinition
        {
            definition.SetField("terrainType", value);
            return definition;
        }
    }
}