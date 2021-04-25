using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class GadgetBlueprintExtensions
    {
        public static GadgetBlueprint SetInteractionNodes(this GadgetBlueprint definition, List<InteractionNodeDescription> value)
        {
            definition.SetField("interactionNodes", value);
            return definition;
        }

        public static GadgetBlueprint SetParameters(this GadgetBlueprint definition, List<GadgetParameterDescription> value)
        {
            definition.SetField("parameters", value);
            return definition;
        }
    }
}