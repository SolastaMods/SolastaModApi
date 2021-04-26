using SolastaModApi.Infrastructure;
using System.Collections.Generic;
using static ActionDefinitions;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionActionAffinityExtensions
    {
        public static T SetActionExecutionModifiers<T>(this T definition, List<ActionExecutionModifier> value)
            where T : FeatureDefinitionActionAffinity
        {
            definition.SetField("actionExecutionModifiers", value);
            return definition;
        }

        public static T SetAuthorizedActions<T>(this T definition, List<Id> value)
            where T : FeatureDefinitionActionAffinity
        {
            definition.SetField("authorizedActions", value);
            return definition;
        }

        public static T SetEitherMainOrBonus<T>(this T definition, bool value)
            where T : FeatureDefinitionActionAffinity
        {
            definition.SetField("eitherMainOrBonus", value);
            return definition;
        }

        public static T SetForbiddenActions<T>(this T definition, List<Id> value)
            where T : FeatureDefinitionActionAffinity
        {
            definition.SetField("forbiddenActions", value);
            return definition;
        }

        public static T SetMaxAttacksNumber<T>(this T definition, int value)
            where T : FeatureDefinitionActionAffinity
        {
            definition.SetField("maxAttacksNumber", value);
            return definition;
        }

        public static T SetRandomBehaviorDie<T>(this T definition, DieType value)
            where T : FeatureDefinitionActionAffinity
        {
            definition.SetField("randomBehaviorDie", value);
            return definition;
        }

        public static T SetRandomBehaviourOptions<T>(this T definition, List<BehaviorModeDescription> value)
            where T : FeatureDefinitionActionAffinity
        {
            definition.SetField("randomBehaviourOptions", value);
            return definition;
        }

        public static T SetRestrictedActions<T>(this T definition, List<Id> value)
            where T : FeatureDefinitionActionAffinity
        {
            definition.SetField("restrictedActions", value);
            return definition;
        }

        public static T SetSpecialBehaviour<T>(this T definition, SpecialBehaviour value)
            where T : FeatureDefinitionActionAffinity
        {
            definition.SetField("specialBehaviour", value);
            return definition;
        }
    }
}