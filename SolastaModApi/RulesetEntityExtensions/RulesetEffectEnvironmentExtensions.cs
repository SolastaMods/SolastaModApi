using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class RulesetEffectEnvironmentExtensions
    {
        public static T SetAddDice<T>(this T entity, int value)
            where T : RulesetEffectEnvironment
        {
            entity.SetField("addDice", value);
            return entity;
        }

        public static T SetEnvironmentEffectDefinition<T>(this T entity, EnvironmentEffectDefinition value)
            where T : RulesetEffectEnvironment
        {
            entity.SetField("environmentEffectDefinition", value);
            return entity;
        }

        public static T SetSavingThrowDCOverride<T>(this T entity, int value)
            where T : RulesetEffectEnvironment
        {
            entity.SetField("savingThrowDCOverride", value);
            return entity;
        }
    }
}