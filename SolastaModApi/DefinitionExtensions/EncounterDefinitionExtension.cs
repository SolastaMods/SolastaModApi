using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class EncounterDefinitionExtensions
    {
        public static EncounterDefinition SetChallengeRating(this EncounterDefinition definition, int value)
        {
            definition.SetField("challengeRating", value);
            return definition;
        }

        public static EncounterDefinition SetLocationOverride(this EncounterDefinition definition, LocationDefinition value)
        {
            definition.SetField("locationOverride", value);
            return definition;
        }

        public static EncounterDefinition SetMonsterOccurences(this EncounterDefinition definition, List<MonsterOccurenceDescription> value)
        {
            definition.SetField("monsterOccurences", value);
            return definition;
        }

        public static EncounterDefinition SetType(this EncounterDefinition definition, EncounterDefinitions.Type value)
        {
            definition.SetField("type", value);
            return definition;
        }
    }
}