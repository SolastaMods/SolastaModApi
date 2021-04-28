using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionDamageAffinityExtensions
    {
        public static T SetDamageAffinityType<T>(this T entity, DamageAffinityType value)
            where T : FeatureDefinitionDamageAffinity
        {
            entity.SetField("damageAffinityType", value);
            return entity;
        }

        public static T SetDamageType<T>(this T entity, string value)
            where T : FeatureDefinitionDamageAffinity
        {
            entity.SetField("damageType", value);
            return entity;
        }

        public static T SetHealBackCap<T>(this T entity, int value)
            where T : FeatureDefinitionDamageAffinity
        {
            entity.SetField("healBackCap", value);
            return entity;
        }

        public static T SetHealsBack<T>(this T entity, bool value)
            where T : FeatureDefinitionDamageAffinity
        {
            entity.SetField("healsBack", value);
            return entity;
        }

        public static T SetInstantDeathImmunity<T>(this T entity, bool value)
            where T : FeatureDefinitionDamageAffinity
        {
            entity.SetField("instantDeathImmunity", value);
            return entity;
        }

        public static T SetKnockOutImmunity<T>(this T entity, bool value)
            where T : FeatureDefinitionDamageAffinity
        {
            entity.SetField("knockOutImmunity", value);
            return entity;
        }

        public static T SetRetaliatePower<T>(this T entity, FeatureDefinitionPower value)
            where T : FeatureDefinitionDamageAffinity
        {
            entity.SetField("retaliatePower", value);
            return entity;
        }

        public static T SetRetaliateProximity<T>(this T entity, AttackProximity value)
            where T : FeatureDefinitionDamageAffinity
        {
            entity.SetField("retaliateProximity", value);
            return entity;
        }

        public static T SetRetaliateRangeCells<T>(this T entity, int value)
            where T : FeatureDefinitionDamageAffinity
        {
            entity.SetField("retaliateRangeCells", value);
            return entity;
        }

        public static T SetRetaliateWhenHit<T>(this T entity, bool value)
            where T : FeatureDefinitionDamageAffinity
        {
            entity.SetField("retaliateWhenHit", value);
            return entity;
        }

        public static T SetSavingThrowAdvantageType<T>(this T entity, AdvantageType value)
            where T : FeatureDefinitionDamageAffinity
        {
            entity.SetField("savingThrowAdvantageType", value);
            return entity;
        }

        public static T SetSavingThrowModifier<T>(this T entity, int value)
            where T : FeatureDefinitionDamageAffinity
        {
            entity.SetField("savingThrowModifier", value);
            return entity;
        }
    }
}