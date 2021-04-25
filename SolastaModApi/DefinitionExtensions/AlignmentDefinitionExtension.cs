using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class AlignmentDefinitionExtensions
    {
        public static void SetDefaultPersonalityFlags(this AlignmentDefinition definition, List<String> value)
        {
            definition.SetField("defaultPersonalityFlags", value);
        }

        public static void SetGoodnessAxis(this AlignmentDefinition definition, Int32 value)
        {
            definition.SetField("goodnessAxis", value);
        }

        public static void SetLawAxis(this AlignmentDefinition definition, Int32 value)
        {
            definition.SetField("lawAxis", value);
        }

        public static void SetOptionalPersonalityFlags(this AlignmentDefinition definition, List<PersonalityFlagOccurence> value)
        {
            definition.SetField("optionalPersonalityFlags", value);
        }
    }
}