using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class CharacterFamilyDefinitionExtensions
    {
        public static T SetExtraplanar<T>(this T definition, bool value)
            where T : CharacterFamilyDefinition
        {
            definition.SetField("extraplanar", value);
            return definition;
        }

        public static T SetFeatures<T>(this T definition, List<FeatureDefinition> value)
            where T : CharacterFamilyDefinition
        {
            definition.SetField("features", value);
            return definition;
        }
    }
}