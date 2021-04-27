using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class EncounterDefinitionExtensions
    {
        public static T SetChallengeRating<T>(this T definition, int value)
            where T : EncounterDefinition
        {
            definition.SetField("challengeRating", value);
            return definition;
        }

        public static T SetLocationOverride<T>(this T definition, LocationDefinition value)
            where T : EncounterDefinition
        {
            definition.SetField("locationOverride", value);
            return definition;
        }

        public static T SetType<T>(this T definition, EncounterDefinitions.Type value)
            where T : EncounterDefinition
        {
            definition.SetField("type", value);
            return definition;
        }
    }
}