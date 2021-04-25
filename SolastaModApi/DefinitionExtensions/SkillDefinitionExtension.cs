using SolastaModApi.Infrastructure;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class SkillDefinitionExtensions
    {
        public static void SetAbilityScore(this SkillDefinition definition, String value)
        {
            definition.SetField("abilityScore", value);
        }

        public static void SetPersonalityAdditiveBase(this SkillDefinition definition, Int32 value)
        {
            definition.SetField("personalityAdditiveBase", value);
        }

        public static void SetPersonalityFlag(this SkillDefinition definition, Boolean value)
        {
            definition.SetField("personalityFlag", value);
        }
    }
}