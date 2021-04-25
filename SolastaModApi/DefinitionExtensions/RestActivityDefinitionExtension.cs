using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class RestActivityDefinitionExtensions
    {
        public static RestActivityDefinition SetCondition(this RestActivityDefinition definition, RestActivityDefinition.ActivityCondition value)
        {
            definition.SetField("condition", value);
            return definition;
        }

        public static RestActivityDefinition SetFunctor(this RestActivityDefinition definition, string value)
        {
            definition.SetField("functor", value);
            return definition;
        }

        public static RestActivityDefinition SetRestStage(this RestActivityDefinition definition, RestDefinitions.RestStage value)
        {
            definition.SetField("restStage", value);
            return definition;
        }

        public static RestActivityDefinition SetRestType(this RestActivityDefinition definition, RestType value)
        {
            definition.SetField("restType", value);
            return definition;
        }

        public static RestActivityDefinition SetStringParameter(this RestActivityDefinition definition, string value)
        {
            definition.SetField("stringParameter", value);
            return definition;
        }
    }
}