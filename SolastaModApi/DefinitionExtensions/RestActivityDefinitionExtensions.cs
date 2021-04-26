using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class RestActivityDefinitionExtensions
    {
        public static T SetCondition<T>(this T definition, RestActivityDefinition.ActivityCondition value)
            where T : RestActivityDefinition
        {
            definition.SetField("condition", value);
            return definition;
        }

        public static T SetFunctor<T>(this T definition, string value)
            where T : RestActivityDefinition
        {
            definition.SetField("functor", value);
            return definition;
        }

        public static T SetRestStage<T>(this T definition, RestDefinitions.RestStage value)
            where T : RestActivityDefinition
        {
            definition.SetField("restStage", value);
            return definition;
        }

        public static T SetRestType<T>(this T definition, RestType value)
            where T : RestActivityDefinition
        {
            definition.SetField("restType", value);
            return definition;
        }

        public static T SetStringParameter<T>(this T definition, string value)
            where T : RestActivityDefinition
        {
            definition.SetField("stringParameter", value);
            return definition;
        }
    }
}