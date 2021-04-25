using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionSubclassChoiceExtensions
    {
        public static FeatureDefinitionSubclassChoice SetFilterByDeity(this FeatureDefinitionSubclassChoice definition, bool value)
        {
            definition.SetField("filterByDeity", value);
            return definition;
        }

        public static FeatureDefinitionSubclassChoice SetSubclasses(this FeatureDefinitionSubclassChoice definition, List<string> value)
        {
            definition.SetField("subclasses", value);
            return definition;
        }

        public static FeatureDefinitionSubclassChoice SetSubclassSuffix(this FeatureDefinitionSubclassChoice definition, string value)
        {
            definition.SetField("subclassSuffix", value);
            return definition;
        }
    }
}