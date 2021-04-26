using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class ReactionDefinitionExtensions
    {
        public static T SetReactDescription<T>(this T definition, string value)
            where T : ReactionDefinition
        {
            definition.SetField("reactDescription", value);
            return definition;
        }

        public static T SetReactTitle<T>(this T definition, string value)
            where T : ReactionDefinition
        {
            definition.SetField("reactTitle", value);
            return definition;
        }
    }
}