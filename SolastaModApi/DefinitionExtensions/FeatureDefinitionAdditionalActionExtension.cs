using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;
using static ActionDefinitions;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionAdditionalActionExtensions
    {
        public static void SetActionType(this FeatureDefinitionAdditionalAction definition, ActionType value)
        {
            definition.SetField("actionType", value);
        }

        public static void SetAuthorizedActions(this FeatureDefinitionAdditionalAction definition, List<Id> value)
        {
            definition.SetField("authorizedActions", value);
        }

        public static void SetForbiddenActions(this FeatureDefinitionAdditionalAction definition, List<Id> value)
        {
            definition.SetField("forbiddenActions", value);
        }

        public static void SetMaxAttacksNumber(this FeatureDefinitionAdditionalAction definition, Int32 value)
        {
            definition.SetField("maxAttacksNumber", value);
        }

        public static void SetRestrictedActions(this FeatureDefinitionAdditionalAction definition, List<Id> value)
        {
            definition.SetField("restrictedActions", value);
        }

        public static void SetTriggerCondition(this FeatureDefinitionAdditionalAction definition, AdditionalActionTriggerCondition value)
        {
            definition.SetField("triggerCondition", value);
        }
    }
}