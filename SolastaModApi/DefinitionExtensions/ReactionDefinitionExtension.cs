using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class ReactionDefinitionExtensions
    {
        public static ReactionDefinition SetReactDescription(this ReactionDefinition definition, string value)
        {
            definition.SetField("reactDescription", value);
            return definition;
        }

        public static ReactionDefinition SetReactTitle(this ReactionDefinition definition, string value)
        {
            definition.SetField("reactTitle", value);
            return definition;
        }
    }
}