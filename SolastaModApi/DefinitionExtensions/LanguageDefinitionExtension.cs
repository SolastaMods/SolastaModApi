using SolastaModApi.Infrastructure;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class LanguageDefinitionExtensions
    {
        public static void SetPersonalityAdditiveBase(this LanguageDefinition definition, Int32 value)
        {
            definition.SetField("personalityAdditiveBase", value);
        }

        public static void SetPersonalityFlag(this LanguageDefinition definition, Boolean value)
        {
            definition.SetField("personalityFlag", value);
        }
    }
}