using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 1.0.12.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FeatureDefinitionLoreExpertise))]
    public static class FeatureDefinitionLoreExpertiseExtensions
    {
        public static T SetExpertiseType<T>(this T entity, FeatureDefinitionLoreExpertise.ExpertiseType value)
            where T : FeatureDefinitionLoreExpertise
        {
            entity.SetField("expertiseType", value);
            return entity;
        }
    }
}