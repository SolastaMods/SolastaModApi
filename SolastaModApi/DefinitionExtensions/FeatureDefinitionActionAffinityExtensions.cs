using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionActionAffinityExtensions
    {
        public static T SetEitherMainOrBonus<T>(this T definition, bool value)
            where T : FeatureDefinitionActionAffinity
        {
            definition.SetField("eitherMainOrBonus", value);
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

        public static T SetSpecialBehaviour<T>(this T definition, SpecialBehaviour value)
            where T : FeatureDefinitionActionAffinity
        {
            definition.SetField("specialBehaviour", value);
            return definition;
        }
    }
}