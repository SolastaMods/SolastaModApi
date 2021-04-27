using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class TravelEventDefinitionExtensions
    {
        public static T SetCooldownValue<T>(this T definition, int value)
            where T : TravelEventDefinition
        {
            definition.SetField("cooldownValue", value);
            return definition;
        }

        public static T SetDumpsAdventureLog<T>(this T definition, bool value)
            where T : TravelEventDefinition
        {
            definition.SetField("dumpsAdventureLog", value);
            return definition;
        }

        public static T SetEventPeriodicity<T>(this T definition, TravelDefinitions.EventPeriodicity value)
            where T : TravelEventDefinition
        {
            definition.SetField("eventPeriodicity", value);
            return definition;
        }

        public static T SetEventType<T>(this T definition, TravelDefinitions.EventType value)
            where T : TravelEventDefinition
        {
            definition.SetField("eventType", value);
            return definition;
        }

        public static T SetRecordedInAdventureLog<T>(this T definition, bool value)
            where T : TravelEventDefinition
        {
            definition.SetField("recordedInAdventureLog", value);
            return definition;
        }
    }
}