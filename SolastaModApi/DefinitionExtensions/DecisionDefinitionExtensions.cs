using SolastaModApi.Infrastructure;
using TA.AI;

namespace SolastaModApi
{
    public static class DecisionDefinitionExtensions
    {
        public static T SetDecision<T>(this T definition, DecisionDescription value)
            where T : DecisionDefinition
        {
            definition.SetField("decision", value);
            return definition;
        }
    }
}