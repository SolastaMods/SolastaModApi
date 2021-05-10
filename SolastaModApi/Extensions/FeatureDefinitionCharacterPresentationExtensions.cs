using SolastaModApi.Infrastructure;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class FeatureDefinitionCharacterPresentationExtensions
    {
        public static T SetForcedBeard<T>(this T entity, string value)
            where T : FeatureDefinitionCharacterPresentation
        {
            entity.SetField("forcedBeard", value);
            return entity;
        }

        public static T SetKeepExistingBeardList<T>(this T entity, string[] value)
            where T : FeatureDefinitionCharacterPresentation
        {
            entity.SetField("keepExistingBeardList", value);
            return entity;
        }

        public static T SetOccurencePercentage<T>(this T entity, int value)
            where T : FeatureDefinitionCharacterPresentation
        {
            entity.SetField("occurencePercentage", value);
            return entity;
        }
    }
}