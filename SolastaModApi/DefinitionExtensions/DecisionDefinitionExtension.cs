using SolastaModApi.Infrastructure;
using TA.AI;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class DecisionDefinitionExtensions
    {
        public static void SetDecision(this DecisionDefinition definition, DecisionDescription value)
        {
            definition.SetField("decision", value);
        }
    }
}