using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionDamageAffinityExtensions
    {
        public static T SetDamageAffinityType<T>(this T definition, DamageAffinityType value)
            where T : FeatureDefinitionDamageAffinity
        {
            definition.SetField("damageAffinityType", value);
            return definition;
        }

        public static T SetDamageType<T>(this T definition, string value)
            where T : FeatureDefinitionDamageAffinity
        {
            definition.SetField("damageType", value);
            return definition;
        }

        public static T SetHealBackCap<T>(this T definition, int value)
            where T : FeatureDefinitionDamageAffinity
        {
            definition.SetField("healBackCap", value);
            return definition;
        }

        public static T SetHealsBack<T>(this T definition, bool value)
            where T : FeatureDefinitionDamageAffinity
        {
            definition.SetField("healsBack", value);
            return definition;
        }

        public static T SetInstantDeathImmunity<T>(this T definition, bool value)
            where T : FeatureDefinitionDamageAffinity
        {
            definition.SetField("instantDeathImmunity", value);
            return definition;
        }

        public static T SetKnockOutImmunity<T>(this T definition, bool value)
            where T : FeatureDefinitionDamageAffinity
        {
            definition.SetField("knockOutImmunity", value);
            return definition;
        }

        public static T SetRetaliatePower<T>(this T definition, FeatureDefinitionPower value)
            where T : FeatureDefinitionDamageAffinity
        {
            definition.SetField("retaliatePower", value);
            return definition;
        }

        public static T SetRetaliateProximity<T>(this T definition, AttackProximity value)
            where T : FeatureDefinitionDamageAffinity
        {
            definition.SetField("retaliateProximity", value);
            return definition;
        }

        public static T SetRetaliateRangeCells<T>(this T definition, int value)
            where T : FeatureDefinitionDamageAffinity
        {
            definition.SetField("retaliateRangeCells", value);
            return definition;
        }

        public static T SetRetaliateWhenHit<T>(this T definition, bool value)
            where T : FeatureDefinitionDamageAffinity
        {
            definition.SetField("retaliateWhenHit", value);
            return definition;
        }

        public static T SetSavingThrowAdvantageType<T>(this T definition, AdvantageType value)
            where T : FeatureDefinitionDamageAffinity
        {
            definition.SetField("savingThrowAdvantageType", value);
            return definition;
        }

        public static T SetSavingThrowModifier<T>(this T definition, int value)
            where T : FeatureDefinitionDamageAffinity
        {
            definition.SetField("savingThrowModifier", value);
            return definition;
        }
    }
}