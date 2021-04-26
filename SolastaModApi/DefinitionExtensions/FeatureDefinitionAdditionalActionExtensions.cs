using SolastaModApi.Infrastructure;
using System.Collections.Generic;
using static ActionDefinitions;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionAdditionalActionExtensions
    {
        public static T SetActionType<T>(this T definition, ActionType value)
            where T : FeatureDefinitionAdditionalAction
        {
            definition.SetField("actionType", value);
            return definition;
        }

        public static T SetAuthorizedActions<T>(this T definition, List<Id> value)
            where T : FeatureDefinitionAdditionalAction
        {
            definition.SetField("authorizedActions", value);
            return definition;
        }

        public static T SetForbiddenActions<T>(this T definition, List<Id> value)
            where T : FeatureDefinitionAdditionalAction
        {
            definition.SetField("forbiddenActions", value);
            return definition;
        }

        public static T SetMaxAttacksNumber<T>(this T definition, int value)
            where T : FeatureDefinitionAdditionalAction
        {
            definition.SetField("maxAttacksNumber", value);
            return definition;
        }

        public static T SetRestrictedActions<T>(this T definition, List<Id> value)
            where T : FeatureDefinitionAdditionalAction
        {
            definition.SetField("restrictedActions", value);
            return definition;
        }

        public static T SetTriggerCondition<T>(this T definition, AdditionalActionTriggerCondition value)
            where T : FeatureDefinitionAdditionalAction
        {
            definition.SetField("triggerCondition", value);
            return definition;
        }
    }
}