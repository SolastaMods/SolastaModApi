using SolastaModApi.Infrastructure;
using System.Text;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionProficiencyExtensions
    {
        public static T SetProficienciesFormat<T>(this T entity, StringBuilder value)
            where T : FeatureDefinitionProficiency
        {
            entity.SetField("proficienciesFormat", value);
            return entity;
        }

        public static T SetProficiencyType<T>(this T entity, ProficiencyType value)
            where T : FeatureDefinitionProficiency
        {
            entity.SetField("proficiencyType", value);
            return entity;
        }
    }
}