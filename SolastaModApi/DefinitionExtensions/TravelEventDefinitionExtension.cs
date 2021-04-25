using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class TravelEventDefinitionExtensions
    {
        public static void SetCooldownValue(this TravelEventDefinition definition, Int32 value)
        {
            definition.SetField("cooldownValue", value);
        }

        public static void SetDumpsAdventureLog(this TravelEventDefinition definition, Boolean value)
        {
            definition.SetField("dumpsAdventureLog", value);
        }

        public static void SetEventPeriodicity(this TravelEventDefinition definition, TravelDefinitions.EventPeriodicity value)
        {
            definition.SetField("eventPeriodicity", value);
        }

        public static void SetEventType(this TravelEventDefinition definition, TravelDefinitions.EventType value)
        {
            definition.SetField("eventType", value);
        }

        public static void SetFailureLogEntries(this TravelEventDefinition definition, List<String> value)
        {
            definition.SetField("failureLogEntries", value);
        }

        public static void SetIngredientGatheringProficiencies(this TravelEventDefinition definition, List<String> value)
        {
            definition.SetField("ingredientGatheringProficiencies", value);
        }

        public static void SetRecordedInAdventureLog(this TravelEventDefinition definition, Boolean value)
        {
            definition.SetField("recordedInAdventureLog", value);
        }

        public static void SetSuccessLogEntries(this TravelEventDefinition definition, List<String> value)
        {
            definition.SetField("successLogEntries", value);
        }
    }
}