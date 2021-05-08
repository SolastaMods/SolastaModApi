using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static partial class PersonalityFlagOccurenceExtensions
    {
        public static T SetPersonalityFlag<T>(this T entity, string value)
            where T : PersonalityFlagOccurence
        {
            entity.SetField("personalityFlag", value);
            return entity;
        }

        public static T SetWeight<T>(this T entity, int value)
            where T : PersonalityFlagOccurence
        {
            entity.SetField("weight", value);
            return entity;
        }
    }
}