using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class BiomeDefinitionExtensions
    {
        public static BiomeDefinition SetEncounterLocations(this BiomeDefinition definition, List<LocationDefinition> value)
        {
            definition.SetField("encounterLocations", value);
            return definition;
        }

        public static BiomeDefinition SetEncounterTable(this BiomeDefinition definition, EncounterTableDefinition value)
        {
            definition.SetField("encounterTable", value);
            return definition;
        }

        public static BiomeDefinition SetNarrativeEventBasicLines(this BiomeDefinition definition, List<string> value)
        {
            definition.SetField("narrativeEventBasicLines", value);
            return definition;
        }

        public static BiomeDefinition SetTerrainType(this BiomeDefinition definition, string value)
        {
            definition.SetField("terrainType", value);
            return definition;
        }
    }
}