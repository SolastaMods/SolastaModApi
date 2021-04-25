using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class CharacterFamilyDefinitionExtensions
    {
        public static void SetExtraplanar(this CharacterFamilyDefinition definition, Boolean value)
        {
            definition.SetField("extraplanar", value);
        }

        public static void SetFeatures(this CharacterFamilyDefinition definition, List<FeatureDefinition> value)
        {
            definition.SetField("features", value);
        }
    }
}