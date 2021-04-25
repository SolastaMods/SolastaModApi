using SolastaModApi.Infrastructure;
using TA.AI;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class DecisionPackageDefinitionExtensions
    {
        public static DecisionPackageDefinition SetPackage(this DecisionPackageDefinition definition, DecisionPackageDescription value)
        {
            definition.SetField("package", value);
            return definition;
        }
    }
}