using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class SkillDefinitionExtensions
    {
        public static T SetAbilityScore<T>(this T definition, string value)
            where T : SkillDefinition
        {
            definition.SetField("abilityScore", value);
            return definition;
        }

        public static T SetPersonalityAdditiveBase<T>(this T definition, int value)
            where T : SkillDefinition
        {
            definition.SetField("personalityAdditiveBase", value);
            return definition;
        }

        public static T SetPersonalityFlag<T>(this T definition, bool value)
            where T : SkillDefinition
        {
            definition.SetField("personalityFlag", value);
            return definition;
        }
    }
}