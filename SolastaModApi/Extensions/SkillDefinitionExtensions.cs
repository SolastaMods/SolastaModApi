using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class SkillDefinitionExtensions
    {
        public static T SetAbilityScore<T>(this T entity, string value)
            where T : SkillDefinition
        {
            entity.SetField("abilityScore", value);
            return entity;
        }

        public static T SetPersonalityAdditiveBase<T>(this T entity, int value)
            where T : SkillDefinition
        {
            entity.SetField("personalityAdditiveBase", value);
            return entity;
        }

        public static T SetPersonalityFlag<T>(this T entity, bool value)
            where T : SkillDefinition
        {
            entity.SetField("personalityFlag", value);
            return entity;
        }
    }
}