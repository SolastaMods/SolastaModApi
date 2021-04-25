using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class BiomeDefinitionExtensions
    {
        public static void SetEncounterLocations(this BiomeDefinition definition, List<LocationDefinition> value)
        {
            definition.SetField("encounterLocations", value);
        }

        public static void SetEncounterTable(this BiomeDefinition definition, EncounterTableDefinition value)
        {
            definition.SetField("encounterTable", value);
        }

        public static void SetNarrativeEventBasicLines(this BiomeDefinition definition, List<String> value)
        {
            definition.SetField("narrativeEventBasicLines", value);
        }

        public static void SetTerrainType(this BiomeDefinition definition, String value)
        {
            definition.SetField("terrainType", value);
        }
    }
}