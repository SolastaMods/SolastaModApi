using SolastaModApi.Infrastructure;
using static ActionDefinitions;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class ActionDefinitionExtensions
    {
        public static ActionDefinition SetAbilityScore(this ActionDefinition definition, string value)
        {
            definition.SetField("abilityScore", value);
            return definition;
        }

        public static ActionDefinition SetActionScope(this ActionDefinition definition, ActionScope value)
        {
            definition.SetField("actionScope", value);
            return definition;
        }

        public static ActionDefinition SetActionType(this ActionDefinition definition, ActionType value)
        {
            definition.SetField("actionType", value);
            return definition;
        }

        public static ActionDefinition SetActivatedPower(this ActionDefinition definition, FeatureDefinitionPower value)
        {
            definition.SetField("activatedPower", value);
            return definition;
        }

        public static ActionDefinition SetAddedConditionName(this ActionDefinition definition, string value)
        {
            definition.SetField("addedConditionName", value);
            return definition;
        }

        public static ActionDefinition SetClassNameOverride(this ActionDefinition definition, string value)
        {
            definition.SetField("classNameOverride", value);
            return definition;
        }

        public static ActionDefinition SetDieType(this ActionDefinition definition, DieType value)
        {
            definition.SetField("dieType", value);
            return definition;
        }

        public static ActionDefinition SetFeedbackOnHoverType(this ActionDefinition definition, FeedbackOnHoverType value)
        {
            definition.SetField("feedbackOnHoverType", value);
            return definition;
        }

        public static ActionDefinition SetFocusCameraOnAction(this ActionDefinition definition, bool value)
        {
            definition.SetField("focusCameraOnAction", value);
            return definition;
        }

        public static ActionDefinition SetFormType(this ActionDefinition definition, ActionFormType value)
        {
            definition.SetField("formType", value);
            return definition;
        }

        public static ActionDefinition SetId(this ActionDefinition definition, Id value)
        {
            definition.SetField("id", value);
            return definition;
        }

        public static ActionDefinition SetIterativeTargeting(this ActionDefinition definition, bool value)
        {
            definition.SetField("iterativeTargeting", value);
            return definition;
        }

        public static ActionDefinition SetMaxCells(this ActionDefinition definition, int value)
        {
            definition.SetField("maxCells", value);
            return definition;
        }

        public static ActionDefinition SetPairedActionId(this ActionDefinition definition, Id value)
        {
            definition.SetField("pairedActionId", value);
            return definition;
        }

        public static ActionDefinition SetParameter(this ActionDefinition definition, ActionParameter value)
        {
            definition.SetField("parameter", value);
            return definition;
        }

        public static ActionDefinition SetPreventsSerialization(this ActionDefinition definition, bool value)
        {
            definition.SetField("preventsSerialization", value);
            return definition;
        }

        public static ActionDefinition SetRemovedConditionName(this ActionDefinition definition, string value)
        {
            definition.SetField("removedConditionName", value);
            return definition;
        }

        public static ActionDefinition SetRequiresAuthorization(this ActionDefinition definition, bool value)
        {
            definition.SetField("requiresAuthorization", value);
            return definition;
        }

        public static ActionDefinition SetStealthBreakerBehavior(this ActionDefinition definition, StealthBreakerBehavior value)
        {
            definition.SetField("stealthBreakerBehavior", value);
            return definition;
        }

        public static ActionDefinition SetUsesPerTurn(this ActionDefinition definition, int value)
        {
            definition.SetField("usesPerTurn", value);
            return definition;
        }
    }
}