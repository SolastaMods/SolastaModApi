using SolastaModApi.Infrastructure;
using static ActionDefinitions;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class ActionDefinitionExtensions
    {
        public static T SetAbilityScore<T>(this T definition, string value)
            where T : ActionDefinition
        {
            definition.SetField("abilityScore", value);
            return definition;
        }

        public static T SetActionScope<T>(this T definition, ActionScope value)
            where T : ActionDefinition
        {
            definition.SetField("actionScope", value);
            return definition;
        }

        public static T SetActionType<T>(this T definition, ActionType value)
            where T : ActionDefinition
        {
            definition.SetField("actionType", value);
            return definition;
        }

        public static T SetActivatedPower<T>(this T definition, FeatureDefinitionPower value)
            where T : ActionDefinition
        {
            definition.SetField("activatedPower", value);
            return definition;
        }

        public static T SetAddedConditionName<T>(this T definition, string value)
            where T : ActionDefinition
        {
            definition.SetField("addedConditionName", value);
            return definition;
        }

        public static T SetClassNameOverride<T>(this T definition, string value)
            where T : ActionDefinition
        {
            definition.SetField("classNameOverride", value);
            return definition;
        }

        public static T SetDieType<T>(this T definition, DieType value)
            where T : ActionDefinition
        {
            definition.SetField("dieType", value);
            return definition;
        }

        public static T SetFeedbackOnHoverType<T>(this T definition, FeedbackOnHoverType value)
            where T : ActionDefinition
        {
            definition.SetField("feedbackOnHoverType", value);
            return definition;
        }

        public static T SetFocusCameraOnAction<T>(this T definition, bool value)
            where T : ActionDefinition
        {
            definition.SetField("focusCameraOnAction", value);
            return definition;
        }

        public static T SetFormType<T>(this T definition, ActionFormType value)
            where T : ActionDefinition
        {
            definition.SetField("formType", value);
            return definition;
        }

        public static T SetId<T>(this T definition, Id value)
            where T : ActionDefinition
        {
            definition.SetField("id", value);
            return definition;
        }

        public static T SetIterativeTargeting<T>(this T definition, bool value)
            where T : ActionDefinition
        {
            definition.SetField("iterativeTargeting", value);
            return definition;
        }

        public static T SetMaxCells<T>(this T definition, int value)
            where T : ActionDefinition
        {
            definition.SetField("maxCells", value);
            return definition;
        }

        public static T SetPairedActionId<T>(this T definition, Id value)
            where T : ActionDefinition
        {
            definition.SetField("pairedActionId", value);
            return definition;
        }

        public static T SetParameter<T>(this T definition, ActionParameter value)
            where T : ActionDefinition
        {
            definition.SetField("parameter", value);
            return definition;
        }

        public static T SetPreventsSerialization<T>(this T definition, bool value)
            where T : ActionDefinition
        {
            definition.SetField("preventsSerialization", value);
            return definition;
        }

        public static T SetRemovedConditionName<T>(this T definition, string value)
            where T : ActionDefinition
        {
            definition.SetField("removedConditionName", value);
            return definition;
        }

        public static T SetRequiresAuthorization<T>(this T definition, bool value)
            where T : ActionDefinition
        {
            definition.SetField("requiresAuthorization", value);
            return definition;
        }

        public static T SetStealthBreakerBehavior<T>(this T definition, StealthBreakerBehavior value)
            where T : ActionDefinition
        {
            definition.SetField("stealthBreakerBehavior", value);
            return definition;
        }

        public static T SetUsesPerTurn<T>(this T definition, int value)
            where T : ActionDefinition
        {
            definition.SetField("usesPerTurn", value);
            return definition;
        }
    }
}