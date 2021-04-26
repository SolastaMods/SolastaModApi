using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class BiomeDefinitionExtensions
    {
        public static T SetEncounterLocations<T>(this T definition, List<LocationDefinition> value)
            where T : BiomeDefinition
        {
            definition.SetField("encounterLocations", value);
            return definition;
        }

        public static T SetEncounterTable<T>(this T definition, EncounterTableDefinition value)
            where T : BiomeDefinition
        {
            definition.SetField("encounterTable", value);
            return definition;
        }

        public static T SetNarrativeEventBasicLines<T>(this T definition, List<string> value)
            where T : BiomeDefinition
        {
            definition.SetField("narrativeEventBasicLines", value);
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