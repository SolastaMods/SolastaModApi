using SolastaModApi.Infrastructure;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class ReactionDefinitionExtensions
    {
        public static void SetReactDescription(this ReactionDefinition definition, String value)
        {
            definition.SetField("reactDescription", value);
        }

        public static void SetReactTitle(this ReactionDefinition definition, String value)
        {
            definition.SetField("reactTitle", value);
        }
    }
}