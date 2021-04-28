using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatureDefinitionCampAffinityExtensions
    {
        public static T SetAwakeWhenCampAttacked<T>(this T entity, bool value)
            where T : FeatureDefinitionCampAffinity
        {
            entity.SetField("awakeWhenCampAttacked", value);
            return entity;
        }

        public static T SetEncounterNoSurpriseInCamp<T>(this T entity, bool value)
            where T : FeatureDefinitionCampAffinity
        {
            entity.SetField("encounterNoSurpriseInCamp", value);
            return entity;
        }

        public static T SetEncounterRollModifier<T>(this T entity, int value)
            where T : FeatureDefinitionCampAffinity
        {
            entity.SetField("encounterRollModifier", value);
            return entity;
        }

        public static T SetSleepDurationOverride<T>(this T entity, int value)
            where T : FeatureDefinitionCampAffinity
        {
            entity.SetField("sleepDurationOverride", value);
            return entity;
        }
    }
}