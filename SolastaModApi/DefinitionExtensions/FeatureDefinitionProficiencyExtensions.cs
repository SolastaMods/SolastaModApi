using SolastaModApi.Infrastructure;
using System.Text;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionProficiencyExtensions
    {
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