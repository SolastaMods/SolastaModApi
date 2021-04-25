using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class EncounterDefinitionExtensions
    {
        public static void SetChallengeRating(this EncounterDefinition definition, Int32 value)
        {
            definition.SetField("challengeRating", value);
        }

        public static void SetLocationOverride(this EncounterDefinition definition, LocationDefinition value)
        {
            definition.SetField("locationOverride", value);
        }

        public static void SetMonsterOccurences(this EncounterDefinition definition, List<MonsterOccurenceDescription> value)
        {
            definition.SetField("monsterOccurences", value);
        }

        public static void SetType(this EncounterDefinition definition, EncounterDefinitions.Type value)
        {
            definition.SetField("type", value);
        }
    }
}