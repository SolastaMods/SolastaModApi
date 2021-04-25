using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class TravelActivityDefinitionExtensions
    {
        public static void SetFatigueImpactPerHour(this TravelActivityDefinition definition, Single value)
        {
            definition.SetField("fatigueImpactPerHour", value);
        }

        public static void SetFixedEvents(this TravelActivityDefinition definition, List<TravelEventFixedOccurenceDescription> value)
        {
            definition.SetField("fixedEvents", value);
        }

        public static void SetIsDynamic(this TravelActivityDefinition definition, Boolean value)
        {
            definition.SetField("isDynamic", value);
        }

        public static void SetNavigationActivity(this TravelActivityDefinition definition, Boolean value)
        {
            definition.SetField("navigationActivity", value);
        }

        public static void SetRandomEvents(this TravelActivityDefinition definition, List<TravelEventProbabilityDescription> value)
        {
            definition.SetField("randomEvents", value);
        }

        public static void SetRestActivity(this TravelActivityDefinition definition, Boolean value)
        {
            definition.SetField("restActivity", value);
        }

        public static void SetStandardDurationHours(this TravelActivityDefinition definition, Int32 value)
        {
            definition.SetField("standardDurationHours", value);
        }

        public static void SetStandardStartHour(this TravelActivityDefinition definition, Int32 value)
        {
            definition.SetField("standardStartHour", value);
        }
    }
}