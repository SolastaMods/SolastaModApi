using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class SkillDefinitionExtensions
    {
        public static SkillDefinition SetAbilityScore(this SkillDefinition definition, string value)
        {
            definition.SetField("abilityScore", value);
            return definition;
        }

        public static SkillDefinition SetPersonalityAdditiveBase(this SkillDefinition definition, int value)
        {
            definition.SetField("personalityAdditiveBase", value);
            return definition;
        }

        public static SkillDefinition SetPersonalityFlag(this SkillDefinition definition, bool value)
        {
            definition.SetField("personalityFlag", value);
            return definition;
        }
    }
}