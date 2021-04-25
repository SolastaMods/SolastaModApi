using SolastaModApi.Infrastructure;
using System.Collections.Generic;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionDamageAffinityExtensions
    {
        public static FeatureDefinitionDamageAffinity SetDamageAffinityType(this FeatureDefinitionDamageAffinity definition, DamageAffinityType value)
        {
            definition.SetField("damageAffinityType", value);
            return definition;
        }

        public static FeatureDefinitionDamageAffinity SetDamageType(this FeatureDefinitionDamageAffinity definition, string value)
        {
            definition.SetField("damageType", value);
            return definition;
        }

        public static FeatureDefinitionDamageAffinity SetHealBackCap(this FeatureDefinitionDamageAffinity definition, int value)
        {
            definition.SetField("healBackCap", value);
            return definition;
        }

        public static FeatureDefinitionDamageAffinity SetHealsBack(this FeatureDefinitionDamageAffinity definition, bool value)
        {
            definition.SetField("healsBack", value);
            return definition;
        }

        public static FeatureDefinitionDamageAffinity SetInstantDeathImmunity(this FeatureDefinitionDamageAffinity definition, bool value)
        {
            definition.SetField("instantDeathImmunity", value);
            return definition;
        }

        public static FeatureDefinitionDamageAffinity SetKnockOutImmunity(this FeatureDefinitionDamageAffinity definition, bool value)
        {
            definition.SetField("knockOutImmunity", value);
            return definition;
        }

        public static FeatureDefinitionDamageAffinity SetRetaliatePower(this FeatureDefinitionDamageAffinity definition, FeatureDefinitionPower value)
        {
            definition.SetField("retaliatePower", value);
            return definition;
        }

        public static FeatureDefinitionDamageAffinity SetRetaliateProximity(this FeatureDefinitionDamageAffinity definition, AttackProximity value)
        {
            definition.SetField("retaliateProximity", value);
            return definition;
        }

        public static FeatureDefinitionDamageAffinity SetRetaliateRangeCells(this FeatureDefinitionDamageAffinity definition, int value)
        {
            definition.SetField("retaliateRangeCells", value);
            return definition;
        }

        public static FeatureDefinitionDamageAffinity SetRetaliateWhenHit(this FeatureDefinitionDamageAffinity definition, bool value)
        {
            definition.SetField("retaliateWhenHit", value);
            return definition;
        }

        public static FeatureDefinitionDamageAffinity SetSavingThrowAdvantageType(this FeatureDefinitionDamageAffinity definition, AdvantageType value)
        {
            definition.SetField("savingThrowAdvantageType", value);
            return definition;
        }

        public static FeatureDefinitionDamageAffinity SetSavingThrowModifier(this FeatureDefinitionDamageAffinity definition, int value)
        {
            definition.SetField("savingThrowModifier", value);
            return definition;
        }

        public static FeatureDefinitionDamageAffinity SetTagsIgnoringAffinity(this FeatureDefinitionDamageAffinity definition, List<string> value)
        {
            definition.SetField("tagsIgnoringAffinity", value);
            return definition;
        }
    }
}