using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class GadgetBlueprintExtensions
    {
        public static void SetInteractionNodes(this GadgetBlueprint definition, List<InteractionNodeDescription> value)
        {
            definition.SetField("interactionNodes", value);
        }

        public static void SetParameters(this GadgetBlueprint definition, List<GadgetParameterDescription> value)
        {
            definition.SetField("parameters", value);
        }
    }
}