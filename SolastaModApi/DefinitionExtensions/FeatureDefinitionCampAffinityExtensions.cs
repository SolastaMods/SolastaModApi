using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatureDefinitionCampAffinityExtensions
    {
        public static T SetAwakeWhenCampAttacked<T>(this T definition, bool value)
            where T : FeatureDefinitionCampAffinity
        {
            definition.SetField("awakeWhenCampAttacked", value);
            return definition;
        }

        public static T SetEncounterNoSurpriseInCamp<T>(this T definition, bool value)
            where T : FeatureDefinitionCampAffinity
        {
            definition.SetField("encounterNoSurpriseInCamp", value);
            return definition;
        }

        public static T SetEncounterRollModifier<T>(this T definition, int value)
            where T : FeatureDefinitionCampAffinity
        {
            definition.SetField("encounterRollModifier", value);
            return definition;
        }

        public static T SetSleepDurationOverride<T>(this T definition, int value)
            where T : FeatureDefinitionCampAffinity
        {
            definition.SetField("sleepDurationOverride", value);
            return definition;
        }
    }
}