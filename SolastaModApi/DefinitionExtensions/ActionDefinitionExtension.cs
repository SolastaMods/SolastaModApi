using SolastaModApi.Infrastructure;
using System;
using static ActionDefinitions;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class ActionDefinitionExtensions
    {
        public static void SetAbilityScore(this ActionDefinition definition, string value)
        {
            definition.SetField("abilityScore", value);
        }

        public static void SetActionScope(this ActionDefinition definition, ActionScope value)
        {
            definition.SetField("actionScope", value);
        }

        public static void SetActionType(this ActionDefinition definition, ActionType value)
        {
            definition.SetField("actionType", value);
        }

        public static void SetActivatedPower(this ActionDefinition definition, FeatureDefinitionPower value)
        {
            definition.SetField("activatedPower", value);
        }

        public static void SetAddedConditionName(this ActionDefinition definition, String value)
        {
            definition.SetField("addedConditionName", value);
        }

        public static void SetClassNameOverride(this ActionDefinition definition, String value)
        {
            definition.SetField("classNameOverride", value);
        }

        public static void SetDieType(this ActionDefinition definition, DieType value)
        {
            definition.SetField("dieType", value);
        }

        public static void SetFeedbackOnHoverType(this ActionDefinition definition, FeedbackOnHoverType value)
        {
            definition.SetField("feedbackOnHoverType", value);
        }

        public static void SetFocusCameraOnAction(this ActionDefinition definition, Boolean value)
        {
            definition.SetField("focusCameraOnAction", value);
        }

        public static void SetFormType(this ActionDefinition definition, ActionFormType value)
        {
            definition.SetField("formType", value);
        }

        public static void SetId(this ActionDefinition definition, Id value)
        {
            definition.SetField("id", value);
        }

        public static void SetIterativeTargeting(this ActionDefinition definition, Boolean value)
        {
            definition.SetField("iterativeTargeting", value);
        }

        public static void SetMaxCells(this ActionDefinition definition, Int32 value)
        {
            definition.SetField("maxCells", value);
        }

        public static void SetPairedActionId(this ActionDefinition definition, Id value)
        {
            definition.SetField("pairedActionId", value);
        }

        public static void SetParameter(this ActionDefinition definition, ActionParameter value)
        {
            definition.SetField("parameter", value);
        }

        public static void SetPreventsSerialization(this ActionDefinition definition, Boolean value)
        {
            definition.SetField("preventsSerialization", value);
        }

        public static void SetRemovedConditionName(this ActionDefinition definition, String value)
        {
            definition.SetField("removedConditionName", value);
        }

        public static void SetRequiresAuthorization(this ActionDefinition definition, Boolean value)
        {
            definition.SetField("requiresAuthorization", value);
        }

        public static void SetStealthBreakerBehavior(this ActionDefinition definition, StealthBreakerBehavior value)
        {
            definition.SetField("stealthBreakerBehavior", value);
        }

        public static void SetUsesPerTurn(this ActionDefinition definition, Int32 value)
        {
            definition.SetField("usesPerTurn", value);
        }
    }
}