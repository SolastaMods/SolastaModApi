using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class ReactionDefinitionExtensions
    {
        public static T SetReactDescription<T>(this T entity, string value)
            where T : ReactionDefinition
        {
            entity.SetField("reactDescription", value);
            return entity;
        }

        public static T SetReactTitle<T>(this T entity, string value)
            where T : ReactionDefinition
        {
            entity.SetField("reactTitle", value);
            return entity;
        }
    }
}