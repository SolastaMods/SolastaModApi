using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class BestiaryStatsDefinitionExtensions
    {
        public static T SetLineHeight<T>(this T definition, float value)
            where T : BestiaryStatsDefinition
        {
            definition.SetField("lineHeight", value);
            return definition;
        }

        public static T SetLineSpacing<T>(this T definition, float value)
            where T : BestiaryStatsDefinition
        {
            definition.SetField("lineSpacing", value);
            return definition;
        }

        public static T SetWordSpacing<T>(this T definition, float value)
            where T : BestiaryStatsDefinition
        {
            definition.SetField("wordSpacing", value);
            return definition;
        }
    }
}