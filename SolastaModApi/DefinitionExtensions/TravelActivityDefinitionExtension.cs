using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class TravelActivityDefinitionExtensions
    {
        public static TravelActivityDefinition SetFatigueImpactPerHour(this TravelActivityDefinition definition, float value)
        {
            definition.SetField("fatigueImpactPerHour", value);
            return definition;
        }

        public static TravelActivityDefinition SetFixedEvents(this TravelActivityDefinition definition, List<TravelEventFixedOccurenceDescription> value)
        {
            definition.SetField("fixedEvents", value);
            return definition;
        }

        public static TravelActivityDefinition SetIsDynamic(this TravelActivityDefinition definition, bool value)
        {
            definition.SetField("isDynamic", value);
            return definition;
        }

        public static TravelActivityDefinition SetNavigationActivity(this TravelActivityDefinition definition, bool value)
        {
            definition.SetField("navigationActivity", value);
            return definition;
        }

        public static TravelActivityDefinition SetRandomEvents(this TravelActivityDefinition definition, List<TravelEventProbabilityDescription> value)
        {
            definition.SetField("randomEvents", value);
            return definition;
        }

        public static TravelActivityDefinition SetRestActivity(this TravelActivityDefinition definition, bool value)
        {
            definition.SetField("restActivity", value);
            return definition;
        }

        public static TravelActivityDefinition SetStandardDurationHours(this TravelActivityDefinition definition, int value)
        {
            definition.SetField("standardDurationHours", value);
            return definition;
        }

        public static TravelActivityDefinition SetStandardStartHour(this TravelActivityDefinition definition, int value)
        {
            definition.SetField("standardStartHour", value);
            return definition;
        }
    }
}