using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;
using static BanterDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class BanterEventDefinitionExtensions
    {
        public static void SetCanUseWhileCautious(this BanterEventDefinition definition, Boolean value)
        {
            definition.SetField("canUseWhileCautious", value);
        }

        public static void SetEventProbability(this BanterEventDefinition definition, Single value)
        {
            definition.SetField("eventProbability", value);
        }

        public static void SetEventTrigger(this BanterEventDefinition definition, String value)
        {
            definition.SetField("eventTrigger", value);
        }

        public static void SetEventVariants(this BanterEventDefinition definition, List<EventVariant> value)
        {
            definition.SetField("eventVariants", value);
        }

        public static void SetPlaybackDelay(this BanterEventDefinition definition, Single value)
        {
            definition.SetField("playbackDelay", value);
        }

        public static void SetSearchKey(this BanterEventDefinition definition, String value)
        {
            definition.SetField("searchKey", value);
        }

        public static void SetSelfProbability(this BanterEventDefinition definition, Single value)
        {
            definition.SetField("selfProbability", value);
        }
    }
}