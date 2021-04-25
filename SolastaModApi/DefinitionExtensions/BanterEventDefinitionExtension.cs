using SolastaModApi.Infrastructure;
using System.Collections.Generic;
using static BanterDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class BanterEventDefinitionExtensions
    {
        public static BanterEventDefinition SetCanUseWhileCautious(this BanterEventDefinition definition, bool value)
        {
            definition.SetField("canUseWhileCautious", value);
            return definition;
        }

        public static BanterEventDefinition SetEventProbability(this BanterEventDefinition definition, float value)
        {
            definition.SetField("eventProbability", value);
            return definition;
        }

        public static BanterEventDefinition SetEventTrigger(this BanterEventDefinition definition, string value)
        {
            definition.SetField("eventTrigger", value);
            return definition;
        }

        public static BanterEventDefinition SetEventVariants(this BanterEventDefinition definition, List<EventVariant> value)
        {
            definition.SetField("eventVariants", value);
            return definition;
        }

        public static BanterEventDefinition SetPlaybackDelay(this BanterEventDefinition definition, float value)
        {
            definition.SetField("playbackDelay", value);
            return definition;
        }

        public static BanterEventDefinition SetSearchKey(this BanterEventDefinition definition, string value)
        {
            definition.SetField("searchKey", value);
            return definition;
        }

        public static BanterEventDefinition SetSelfProbability(this BanterEventDefinition definition, float value)
        {
            definition.SetField("selfProbability", value);
            return definition;
        }
    }
}