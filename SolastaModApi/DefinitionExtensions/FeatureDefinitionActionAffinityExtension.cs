using SolastaModApi.Infrastructure;
using System.Collections.Generic;
using static ActionDefinitions;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionActionAffinityExtensions
    {
        public static FeatureDefinitionActionAffinity SetActionExecutionModifiers(this FeatureDefinitionActionAffinity definition, List<ActionExecutionModifier> value)
        {
            definition.SetField("actionExecutionModifiers", value);
            return definition;
        }

        public static FeatureDefinitionActionAffinity SetAuthorizedActions(this FeatureDefinitionActionAffinity definition, List<Id> value)
        {
            definition.SetField("authorizedActions", value);
            return definition;
        }

        public static FeatureDefinitionActionAffinity SetEitherMainOrBonus(this FeatureDefinitionActionAffinity definition, bool value)
        {
            definition.SetField("eitherMainOrBonus", value);
            return definition;
        }

        public static FeatureDefinitionActionAffinity SetForbiddenActions(this FeatureDefinitionActionAffinity definition, List<Id> value)
        {
            definition.SetField("forbiddenActions", value);
            return definition;
        }

        public static FeatureDefinitionActionAffinity SetMaxAttacksNumber(this FeatureDefinitionActionAffinity definition, int value)
        {
            definition.SetField("maxAttacksNumber", value);
            return definition;
        }

        public static FeatureDefinitionActionAffinity SetRandomBehaviorDie(this FeatureDefinitionActionAffinity definition, DieType value)
        {
            definition.SetField("randomBehaviorDie", value);
            return definition;
        }

        public static FeatureDefinitionActionAffinity SetRandomBehaviourOptions(this FeatureDefinitionActionAffinity definition, List<BehaviorModeDescription> value)
        {
            definition.SetField("randomBehaviourOptions", value);
            return definition;
        }

        public static FeatureDefinitionActionAffinity SetRestrictedActions(this FeatureDefinitionActionAffinity definition, List<Id> value)
        {
            definition.SetField("restrictedActions", value);
            return definition;
        }

        public static FeatureDefinitionActionAffinity SetSpecialBehaviour(this FeatureDefinitionActionAffinity definition, SpecialBehaviour value)
        {
            definition.SetField("specialBehaviour", value);
            return definition;
        }
    }
}