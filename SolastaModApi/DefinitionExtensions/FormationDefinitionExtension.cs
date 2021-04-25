using SolastaModApi.Infrastructure;
using System;
using TA;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FormationDefinitionExtensions
    {
        public static void SetDefaultFormation(this FormationDefinition definition, Boolean value)
        {
            definition.SetField("defaultFormation", value);
        }

        public static void SetFormationPositions(this FormationDefinition definition, List<int3> value)
        {
            definition.SetField("formationPositions", value);
        }
    }
}