using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class TravelEventDefinitionExtensions
    {
        public static TravelEventDefinition SetCooldownValue(this TravelEventDefinition definition, int value)
        {
            definition.SetField("cooldownValue", value);
            return definition;
        }

        public static TravelEventDefinition SetDumpsAdventureLog(this TravelEventDefinition definition, bool value)
        {
            definition.SetField("dumpsAdventureLog", value);
            return definition;
        }

        public static TravelEventDefinition SetEventPeriodicity(this TravelEventDefinition definition, TravelDefinitions.EventPeriodicity value)
        {
            definition.SetField("eventPeriodicity", value);
            return definition;
        }

        public static TravelEventDefinition SetEventType(this TravelEventDefinition definition, TravelDefinitions.EventType value)
        {
            definition.SetField("eventType", value);
            return definition;
        }

        public static TravelEventDefinition SetFailureLogEntries(this TravelEventDefinition definition, List<string> value)
        {
            definition.SetField("failureLogEntries", value);
            return definition;
        }

        public static TravelEventDefinition SetIngredientGatheringProficiencies(this TravelEventDefinition definition, List<string> value)
        {
            definition.SetField("ingredientGatheringProficiencies", value);
            return definition;
        }

        public static TravelEventDefinition SetRecordedInAdventureLog(this TravelEventDefinition definition, bool value)
        {
            definition.SetField("recordedInAdventureLog", value);
            return definition;
        }

        public static TravelEventDefinition SetSuccessLogEntries(this TravelEventDefinition definition, List<string> value)
        {
            definition.SetField("successLogEntries", value);
            return definition;
        }
    }
}