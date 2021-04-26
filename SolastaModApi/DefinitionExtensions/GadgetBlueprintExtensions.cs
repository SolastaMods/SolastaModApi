using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class GadgetBlueprintExtensions
    {
        public static T SetInteractionNodes<T>(this T definition, List<InteractionNodeDescription> value)
            where T : GadgetBlueprint
        {
            definition.SetField("interactionNodes", value);
            return definition;
        }

        public static T SetParameters<T>(this T definition, List<GadgetParameterDescription> value)
            where T : GadgetBlueprint
        {
            definition.SetField("parameters", value);
            return definition;
        }
    }
}