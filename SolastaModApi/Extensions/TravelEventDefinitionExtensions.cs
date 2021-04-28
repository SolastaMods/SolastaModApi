using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class TravelEventDefinitionExtensions
    {
        public static T SetCooldownValue<T>(this T entity, int value)
            where T : TravelEventDefinition
        {
            entity.SetField("cooldownValue", value);
            return entity;
        }

        public static T SetDumpsAdventureLog<T>(this T entity, bool value)
            where T : TravelEventDefinition
        {
            entity.SetField("dumpsAdventureLog", value);
            return entity;
        }

        public static T SetEventPeriodicity<T>(this T entity, TravelDefinitions.EventPeriodicity value)
            where T : TravelEventDefinition
        {
            entity.SetField("eventPeriodicity", value);
            return entity;
        }

        public static T SetEventType<T>(this T entity, TravelDefinitions.EventType value)
            where T : TravelEventDefinition
        {
            entity.SetField("eventType", value);
            return entity;
        }

        public static T SetRecordedInAdventureLog<T>(this T entity, bool value)
            where T : TravelEventDefinition
        {
            entity.SetField("recordedInAdventureLog", value);
            return entity;
        }
    }
}