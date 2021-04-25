using SolastaModApi.Infrastructure;
using TA;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FormationDefinitionExtensions
    {
        public static FormationDefinition SetDefaultFormation(this FormationDefinition definition, bool value)
        {
            definition.SetField("defaultFormation", value);
            return definition;
        }

        public static FormationDefinition SetFormationPositions(this FormationDefinition definition, List<int3> value)
        {
            definition.SetField("formationPositions", value);
            return definition;
        }
    }
}