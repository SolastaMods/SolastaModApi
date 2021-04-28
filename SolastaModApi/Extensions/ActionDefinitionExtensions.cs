using SolastaModApi.Infrastructure;
using static ActionDefinitions;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class ActionDefinitionExtensions
    {
        public static T SetAbilityScore<T>(this T entity, string value)
            where T : ActionDefinition
        {
            entity.SetField("abilityScore", value);
            return entity;
        }

        public static T SetActionScope<T>(this T entity, ActionScope value)
            where T : ActionDefinition
        {
            entity.SetField("actionScope", value);
            return entity;
        }

        public static T SetActionType<T>(this T entity, ActionType value)
            where T : ActionDefinition
        {
            entity.SetField("actionType", value);
            return entity;
        }

        public static T SetActivatedPower<T>(this T entity, FeatureDefinitionPower value)
            where T : ActionDefinition
        {
            entity.SetField("activatedPower", value);
            return entity;
        }

        public static T SetAddedConditionName<T>(this T entity, string value)
            where T : ActionDefinition
        {
            entity.SetField("addedConditionName", value);
            return entity;
        }

        public static T SetClassNameOverride<T>(this T entity, string value)
            where T : ActionDefinition
        {
            entity.SetField("classNameOverride", value);
            return entity;
        }

        public static T SetDieType<T>(this T entity, DieType value)
            where T : ActionDefinition
        {
            entity.SetField("dieType", value);
            return entity;
        }

        public static T SetFeedbackOnHoverType<T>(this T entity, FeedbackOnHoverType value)
            where T : ActionDefinition
        {
            entity.SetField("feedbackOnHoverType", value);
            return entity;
        }

        public static T SetFocusCameraOnAction<T>(this T entity, bool value)
            where T : ActionDefinition
        {
            entity.SetField("focusCameraOnAction", value);
            return entity;
        }

        public static T SetFormType<T>(this T entity, ActionFormType value)
            where T : ActionDefinition
        {
            entity.SetField("formType", value);
            return entity;
        }

        public static T SetId<T>(this T entity, Id value)
            where T : ActionDefinition
        {
            entity.SetField("id", value);
            return entity;
        }

        public static T SetIterativeTargeting<T>(this T entity, bool value)
            where T : ActionDefinition
        {
            entity.SetField("iterativeTargeting", value);
            return entity;
        }

        public static T SetMaxCells<T>(this T entity, int value)
            where T : ActionDefinition
        {
            entity.SetField("maxCells", value);
            return entity;
        }

        public static T SetPairedActionId<T>(this T entity, Id value)
            where T : ActionDefinition
        {
            entity.SetField("pairedActionId", value);
            return entity;
        }

        public static T SetParameter<T>(this T entity, ActionParameter value)
            where T : ActionDefinition
        {
            entity.SetField("parameter", value);
            return entity;
        }

        public static T SetPreventsSerialization<T>(this T entity, bool value)
            where T : ActionDefinition
        {
            entity.SetField("preventsSerialization", value);
            return entity;
        }

        public static T SetRemovedConditionName<T>(this T entity, string value)
            where T : ActionDefinition
        {
            entity.SetField("removedConditionName", value);
            return entity;
        }

        public static T SetRequiresAuthorization<T>(this T entity, bool value)
            where T : ActionDefinition
        {
            entity.SetField("requiresAuthorization", value);
            return entity;
        }

        public static T SetStealthBreakerBehavior<T>(this T entity, StealthBreakerBehavior value)
            where T : ActionDefinition
        {
            entity.SetField("stealthBreakerBehavior", value);
            return entity;
        }

        public static T SetUsesPerTurn<T>(this T entity, int value)
            where T : ActionDefinition
        {
            entity.SetField("usesPerTurn", value);
            return entity;
        }
    }
}