using SolastaModApi.Infrastructure;
using TA;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class FormationDefinitionExtensions
    {
        public static T SetDefaultFormation<T>(this T definition, bool value)
            where T : FormationDefinition
        {
            definition.SetField("defaultFormation", value);
            return definition;
        }

        public static T SetFormationPositions<T>(this T definition, List<int3> value)
            where T : FormationDefinition
        {
            definition.SetField("formationPositions", value);
            return definition;
        }
    }
}