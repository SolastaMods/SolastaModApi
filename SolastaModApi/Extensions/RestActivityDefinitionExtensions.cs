using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class RestActivityDefinitionExtensions
    {
        public static T SetCondition<T>(this T entity, RestActivityDefinition.ActivityCondition value)
            where T : RestActivityDefinition
        {
            entity.SetField("condition", value);
            return entity;
        }

        public static T SetFunctor<T>(this T entity, string value)
            where T : RestActivityDefinition
        {
            entity.SetField("functor", value);
            return entity;
        }

        public static T SetRestStage<T>(this T entity, RestDefinitions.RestStage value)
            where T : RestActivityDefinition
        {
            entity.SetField("restStage", value);
            return entity;
        }

        public static T SetRestType<T>(this T entity, RestType value)
            where T : RestActivityDefinition
        {
            entity.SetField("restType", value);
            return entity;
        }

        public static T SetStringParameter<T>(this T entity, string value)
            where T : RestActivityDefinition
        {
            entity.SetField("stringParameter", value);
            return entity;
        }
    }
}