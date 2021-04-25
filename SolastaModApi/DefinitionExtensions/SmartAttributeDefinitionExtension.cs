using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class SmartAttributeDefinitionExtensions
    {
        public static SmartAttributeDefinition SetModifiedAttributes(this SmartAttributeDefinition definition, List<string> value)
        {
            definition.SetField("modifiedAttributes", value);
            return definition;
        }
    }
}