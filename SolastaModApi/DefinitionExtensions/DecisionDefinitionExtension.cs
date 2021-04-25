using SolastaModApi.Infrastructure;
using TA.AI;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class DecisionDefinitionExtensions
    {
        public static DecisionDefinition SetDecision(this DecisionDefinition definition, DecisionDescription value)
        {
            definition.SetField("decision", value);
            return definition;
        }
    }
}