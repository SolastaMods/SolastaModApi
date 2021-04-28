using SolastaModApi.Infrastructure;
using TA.AI;

namespace SolastaModApi
{
    public static class DecisionDefinitionExtensions
    {
        public static T SetDecision<T>(this T entity, DecisionDescription value)
            where T : DecisionDefinition
        {
            entity.SetField("decision", value);
            return entity;
        }
    }
}