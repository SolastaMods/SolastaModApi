using SolastaModApi.Infrastructure;
using System.Collections.Generic;
using static ActionDefinitions;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionAdditionalActionExtensions
    {
        public static FeatureDefinitionAdditionalAction SetActionType(this FeatureDefinitionAdditionalAction definition, ActionType value)
        {
            definition.SetField("actionType", value);
            return definition;
        }

        public static FeatureDefinitionAdditionalAction SetAuthorizedActions(this FeatureDefinitionAdditionalAction definition, List<Id> value)
        {
            definition.SetField("authorizedActions", value);
            return definition;
        }

        public static FeatureDefinitionAdditionalAction SetForbiddenActions(this FeatureDefinitionAdditionalAction definition, List<Id> value)
        {
            definition.SetField("forbiddenActions", value);
            return definition;
        }

        public static FeatureDefinitionAdditionalAction SetMaxAttacksNumber(this FeatureDefinitionAdditionalAction definition, int value)
        {
            definition.SetField("maxAttacksNumber", value);
            return definition;
        }

        public static FeatureDefinitionAdditionalAction SetRestrictedActions(this FeatureDefinitionAdditionalAction definition, List<Id> value)
        {
            definition.SetField("restrictedActions", value);
            return definition;
        }

        public static FeatureDefinitionAdditionalAction SetTriggerCondition(this FeatureDefinitionAdditionalAction definition, AdditionalActionTriggerCondition value)
        {
            definition.SetField("triggerCondition", value);
            return definition;
        }
    }
}