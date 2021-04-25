using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class AlignmentDefinitionExtensions
    {
        public static AlignmentDefinition SetDefaultPersonalityFlags(this AlignmentDefinition definition, List<string> value)
        {
            definition.SetField("defaultPersonalityFlags", value);
            return definition;
        }

        public static AlignmentDefinition SetGoodnessAxis(this AlignmentDefinition definition, int value)
        {
            definition.SetField("goodnessAxis", value);
            return definition;
        }

        public static AlignmentDefinition SetLawAxis(this AlignmentDefinition definition, int value)
        {
            definition.SetField("lawAxis", value);
            return definition;
        }

        public static AlignmentDefinition SetOptionalPersonalityFlags(this AlignmentDefinition definition, List<PersonalityFlagOccurence> value)
        {
            definition.SetField("optionalPersonalityFlags", value);
            return definition;
        }
    }
}