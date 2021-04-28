using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class BestiaryStatsDefinitionExtensions
    {
        public static T SetLineHeight<T>(this T entity, float value)
            where T : BestiaryStatsDefinition
        {
            entity.SetField("lineHeight", value);
            return entity;
        }

        public static T SetLineSpacing<T>(this T entity, float value)
            where T : BestiaryStatsDefinition
        {
            entity.SetField("lineSpacing", value);
            return entity;
        }

        public static T SetWordSpacing<T>(this T entity, float value)
            where T : BestiaryStatsDefinition
        {
            entity.SetField("wordSpacing", value);
            return entity;
        }
    }
}