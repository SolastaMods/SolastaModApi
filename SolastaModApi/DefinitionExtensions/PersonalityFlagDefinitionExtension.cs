using SolastaModApi.Infrastructure;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class PersonalityFlagDefinitionExtensions
    {
        public static void SetDialog(this PersonalityFlagDefinition definition, Boolean value)
        {
            definition.SetField("dialog", value);
        }

        public static void SetGameplay(this PersonalityFlagDefinition definition, Boolean value)
        {
            definition.SetField("gameplay", value);
        }
    }
}