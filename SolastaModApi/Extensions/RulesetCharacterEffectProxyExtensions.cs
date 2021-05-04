using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class RulesetCharacterEffectProxyExtensions
    {
        public static T SetControllerGuid<T>(this T entity, ulong value)
            where T : RulesetCharacterEffectProxy
        {
            entity.SetField("controllerGuid", value);
            return entity;
        }

        public static T SetEffectDefinitionName<T>(this T entity, string value)
            where T : RulesetCharacterEffectProxy
        {
            entity.SetField("effectDefinitionName", value);
            return entity;
        }

        public static T SetEffectGuid<T>(this T entity, ulong value)
            where T : RulesetCharacterEffectProxy
        {
            entity.SetField("effectGuid", value);
            return entity;
        }

        public static T SetEffectProxyDefinition<T>(this T entity, EffectProxyDefinition value)
            where T : RulesetCharacterEffectProxy
        {
            entity.SetField("effectProxyDefinition", value);
            return entity;
        }

        public static T SetSourceAbilityBonus<T>(this T entity, int value)
            where T : RulesetCharacterEffectProxy
        {
            entity.SetField("sourceAbilityBonus", value);
            return entity;
        }

        public static T SetSourceAbilityName<T>(this T entity, string value)
            where T : RulesetCharacterEffectProxy
        {
            entity.SetField("sourceAbilityName", value);
            return entity;
        }

        public static T SetSourceDC<T>(this T entity, int value)
            where T : RulesetCharacterEffectProxy
        {
            entity.SetField("sourceDC", value);
            return entity;
        }

        public static T SetSourceProficiencyBonus<T>(this T entity, int value)
            where T : RulesetCharacterEffectProxy
        {
            entity.SetField("sourceProficiencyBonus", value);
            return entity;
        }
    }
}