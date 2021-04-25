using SolastaModApi.Infrastructure;
using System.Text;
using System.Collections.Generic;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionProficiencyExtensions
    {
        public static FeatureDefinitionProficiency SetProficiencies(this FeatureDefinitionProficiency definition, List<string> value)
        {
            definition.SetField("proficiencies", value);
            return definition;
        }

        public static FeatureDefinitionProficiency SetProficienciesFormat(this FeatureDefinitionProficiency definition, StringBuilder value)
        {
            definition.SetField("proficienciesFormat", value);
            return definition;
        }

        public static FeatureDefinitionProficiency SetProficiencyType(this FeatureDefinitionProficiency definition, ProficiencyType value)
        {
            definition.SetField("proficiencyType", value);
            return definition;
        }
    }
}