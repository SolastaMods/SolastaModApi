using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class CharacterFamilyDefinitionExtensions
    {
        public static CharacterFamilyDefinition SetExtraplanar(this CharacterFamilyDefinition definition, bool value)
        {
            definition.SetField("extraplanar", value);
            return definition;
        }

        public static CharacterFamilyDefinition SetFeatures(this CharacterFamilyDefinition definition, List<FeatureDefinition> value)
        {
            definition.SetField("features", value);
            return definition;
        }
    }
}