using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionCampAffinityExtensions
    {
        public static FeatureDefinitionCampAffinity SetAwakeWhenCampAttacked(this FeatureDefinitionCampAffinity definition, bool value)
        {
            definition.SetField("awakeWhenCampAttacked", value);
            return definition;
        }

        public static FeatureDefinitionCampAffinity SetEncounterNoSurpriseInCamp(this FeatureDefinitionCampAffinity definition, bool value)
        {
            definition.SetField("encounterNoSurpriseInCamp", value);
            return definition;
        }

        public static FeatureDefinitionCampAffinity SetEncounterRollModifier(this FeatureDefinitionCampAffinity definition, int value)
        {
            definition.SetField("encounterRollModifier", value);
            return definition;
        }

        public static FeatureDefinitionCampAffinity SetSleepDurationOverride(this FeatureDefinitionCampAffinity definition, int value)
        {
            definition.SetField("sleepDurationOverride", value);
            return definition;
        }
    }
}