using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class FeatureDefinitionPointPoolExtensions
    {
        public static T SetPoolAmount<T>(this T entity, int value)
            where T : FeatureDefinitionPointPool
        {
            entity.SetField("poolAmount", value);
            return entity;
        }

        public static T SetPoolType<T>(this T entity, HeroDefinitions.PointsPoolType value)
            where T : FeatureDefinitionPointPool
        {
            entity.SetField("poolType", value);
            return entity;
        }

        public static T SetUniqueChoices<T>(this T entity, bool value)
            where T : FeatureDefinitionPointPool
        {
            entity.SetField("uniqueChoices", value);
            return entity;
        }
    }
}