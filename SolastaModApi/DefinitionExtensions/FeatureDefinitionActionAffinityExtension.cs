using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;
using static ActionDefinitions;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionActionAffinityExtensions
    {
        public static void SetActionExecutionModifiers(this FeatureDefinitionActionAffinity definition, List<ActionExecutionModifier> value)
        {
            definition.SetField("actionExecutionModifiers", value);
        }

        public static void SetAuthorizedActions(this FeatureDefinitionActionAffinity definition, List<Id> value)
        {
            definition.SetField("authorizedActions", value);
        }

        public static void SetEitherMainOrBonus(this FeatureDefinitionActionAffinity definition, Boolean value)
        {
            definition.SetField("eitherMainOrBonus", value);
        }

        public static void SetForbiddenActions(this FeatureDefinitionActionAffinity definition, List<Id> value)
        {
            definition.SetField("forbiddenActions", value);
        }

        public static void SetMaxAttacksNumber(this FeatureDefinitionActionAffinity definition, Int32 value)
        {
            definition.SetField("maxAttacksNumber", value);
        }

        public static void SetRandomBehaviorDie(this FeatureDefinitionActionAffinity definition, DieType value)
        {
            definition.SetField("randomBehaviorDie", value);
        }

        public static void SetRandomBehaviourOptions(this FeatureDefinitionActionAffinity definition, List<BehaviorModeDescription> value)
        {
            definition.SetField("randomBehaviourOptions", value);
        }

        public static void SetRestrictedActions(this FeatureDefinitionActionAffinity definition, List<Id> value)
        {
            definition.SetField("restrictedActions", value);
        }

        public static void SetSpecialBehaviour(this FeatureDefinitionActionAffinity definition, SpecialBehaviour value)
        {
            definition.SetField("specialBehaviour", value);
        }
    }
}