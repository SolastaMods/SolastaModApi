using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionSubclassChoiceExtensions
    {
        public static void SetFilterByDeity(this FeatureDefinitionSubclassChoice definition, Boolean value)
        {
            definition.SetField("filterByDeity", value);
        }

        public static void SetSubclasses(this FeatureDefinitionSubclassChoice definition, List<String> value)
        {
            definition.SetField("subclasses", value);
        }

        public static void SetSubclassSuffix(this FeatureDefinitionSubclassChoice definition, String value)
        {
            definition.SetField("subclassSuffix", value);
        }
    }
}