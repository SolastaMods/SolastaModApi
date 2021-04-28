using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class EncounterDefinitionExtensions
    {
        public static T SetChallengeRating<T>(this T entity, int value)
            where T : EncounterDefinition
        {
            entity.SetField("challengeRating", value);
            return entity;
        }

        public static T SetLocationOverride<T>(this T entity, LocationDefinition value)
            where T : EncounterDefinition
        {
            entity.SetField("locationOverride", value);
            return entity;
        }

        public static T SetType<T>(this T entity, EncounterDefinitions.Type value)
            where T : EncounterDefinition
        {
            entity.SetField("type", value);
            return entity;
        }
    }
}