using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class TravelActivityDefinitionExtensions
    {
        public static T SetFatigueImpactPerHour<T>(this T definition, float value)
            where T : TravelActivityDefinition
        {
            definition.SetField("fatigueImpactPerHour", value);
            return definition;
        }

        public static T SetFixedEvents<T>(this T definition, List<TravelEventFixedOccurenceDescription> value)
            where T : TravelActivityDefinition
        {
            definition.SetField("fixedEvents", value);
            return definition;
        }

        public static T SetIsDynamic<T>(this T definition, bool value)
            where T : TravelActivityDefinition
        {
            definition.SetField("isDynamic", value);
            return definition;
        }

        public static T SetNavigationActivity<T>(this T definition, bool value)
            where T : TravelActivityDefinition
        {
            definition.SetField("navigationActivity", value);
            return definition;
        }

        public static T SetRandomEvents<T>(this T definition, List<TravelEventProbabilityDescription> value)
            where T : TravelActivityDefinition
        {
            definition.SetField("randomEvents", value);
            return definition;
        }

        public static T SetRestActivity<T>(this T definition, bool value)
            where T : TravelActivityDefinition
        {
            definition.SetField("restActivity", value);
            return definition;
        }

        public static T SetStandardDurationHours<T>(this T definition, int value)
            where T : TravelActivityDefinition
        {
            definition.SetField("standardDurationHours", value);
            return definition;
        }

        public static T SetStandardStartHour<T>(this T definition, int value)
            where T : TravelActivityDefinition
        {
            definition.SetField("standardStartHour", value);
            return definition;
        }
    }
}