using SolastaModApi.Infrastructure;
using System.Text;
using System.Collections.Generic;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionProficiencyExtensions
    {
        public static T SetProficiencies<T>(this T definition, List<string> value)
            where T : FeatureDefinitionProficiency
        {
            definition.SetField("proficiencies", value);
            return definition;
        }

        public static T SetProficienciesFormat<T>(this T definition, StringBuilder value)
            where T : FeatureDefinitionProficiency
        {
            definition.SetField("proficienciesFormat", value);
            return definition;
        }

        public static T SetProficiencyType<T>(this T definition, ProficiencyType value)
            where T : FeatureDefinitionProficiency
        {
            definition.SetField("proficiencyType", value);
            return definition;
        }
    }
}