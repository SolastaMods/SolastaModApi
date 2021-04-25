using SolastaModApi.Infrastructure;
using System;
using System.Text;
using System.Collections.Generic;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionProficiencyExtensions
    {
        public static void SetProficiencies(this FeatureDefinitionProficiency definition, List<String> value)
        {
            definition.SetField("proficiencies", value);
        }

        public static void SetProficienciesFormat(this FeatureDefinitionProficiency definition, StringBuilder value)
        {
            definition.SetField("proficienciesFormat", value);
        }

        public static void SetProficiencyType(this FeatureDefinitionProficiency definition, ProficiencyType value)
        {
            definition.SetField("proficiencyType", value);
        }
    }
}