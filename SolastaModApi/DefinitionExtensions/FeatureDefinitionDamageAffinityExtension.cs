using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionDamageAffinityExtensions
    {
        public static void SetDamageAffinityType(this FeatureDefinitionDamageAffinity definition, DamageAffinityType value)
        {
            definition.SetField("damageAffinityType", value);
        }

        public static void SetDamageType(this FeatureDefinitionDamageAffinity definition, String value)
        {
            definition.SetField("damageType", value);
        }

        public static void SetHealBackCap(this FeatureDefinitionDamageAffinity definition, Int32 value)
        {
            definition.SetField("healBackCap", value);
        }

        public static void SetHealsBack(this FeatureDefinitionDamageAffinity definition, Boolean value)
        {
            definition.SetField("healsBack", value);
        }

        public static void SetInstantDeathImmunity(this FeatureDefinitionDamageAffinity definition, Boolean value)
        {
            definition.SetField("instantDeathImmunity", value);
        }

        public static void SetKnockOutImmunity(this FeatureDefinitionDamageAffinity definition, Boolean value)
        {
            definition.SetField("knockOutImmunity", value);
        }

        public static void SetRetaliatePower(this FeatureDefinitionDamageAffinity definition, FeatureDefinitionPower value)
        {
            definition.SetField("retaliatePower", value);
        }

        public static void SetRetaliateProximity(this FeatureDefinitionDamageAffinity definition, AttackProximity value)
        {
            definition.SetField("retaliateProximity", value);
        }

        public static void SetRetaliateRangeCells(this FeatureDefinitionDamageAffinity definition, Int32 value)
        {
            definition.SetField("retaliateRangeCells", value);
        }

        public static void SetRetaliateWhenHit(this FeatureDefinitionDamageAffinity definition, Boolean value)
        {
            definition.SetField("retaliateWhenHit", value);
        }

        public static void SetSavingThrowAdvantageType(this FeatureDefinitionDamageAffinity definition, AdvantageType value)
        {
            definition.SetField("savingThrowAdvantageType", value);
        }

        public static void SetSavingThrowModifier(this FeatureDefinitionDamageAffinity definition, Int32 value)
        {
            definition.SetField("savingThrowModifier", value);
        }

        public static void SetTagsIgnoringAffinity(this FeatureDefinitionDamageAffinity definition, List<String> value)
        {
            definition.SetField("tagsIgnoringAffinity", value);
        }
    }
}