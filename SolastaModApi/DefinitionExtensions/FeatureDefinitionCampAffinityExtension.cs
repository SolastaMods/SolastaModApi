using SolastaModApi.Infrastructure;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionCampAffinityExtensions
    {
        public static void SetAwakeWhenCampAttacked(this FeatureDefinitionCampAffinity definition, Boolean value)
        {
            definition.SetField("awakeWhenCampAttacked", value);
        }

        public static void SetEncounterNoSurpriseInCamp(this FeatureDefinitionCampAffinity definition, Boolean value)
        {
            definition.SetField("encounterNoSurpriseInCamp", value);
        }

        public static void SetEncounterRollModifier(this FeatureDefinitionCampAffinity definition, Int32 value)
        {
            definition.SetField("encounterRollModifier", value);
        }

        public static void SetSleepDurationOverride(this FeatureDefinitionCampAffinity definition, Int32 value)
        {
            definition.SetField("sleepDurationOverride", value);
        }
    }
}