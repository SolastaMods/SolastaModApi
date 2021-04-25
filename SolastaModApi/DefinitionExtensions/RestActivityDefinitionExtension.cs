using SolastaModApi.Infrastructure;
using System;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class RestActivityDefinitionExtensions
    {
        public static void SetCondition(this RestActivityDefinition definition, RestActivityDefinition.ActivityCondition value)
        {
            definition.SetField("condition", value);
        }

        public static void SetFunctor(this RestActivityDefinition definition, String value)
        {
            definition.SetField("functor", value);
        }

        public static void SetRestStage(this RestActivityDefinition definition, RestDefinitions.RestStage value)
        {
            definition.SetField("restStage", value);
        }

        public static void SetRestType(this RestActivityDefinition definition, RestType value)
        {
            definition.SetField("restType", value);
        }

        public static void SetStringParameter(this RestActivityDefinition definition, String value)
        {
            definition.SetField("stringParameter", value);
        }
    }
}