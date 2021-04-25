using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class SmartAttributeDefinitionExtensions
    {
        public static void SetModifiedAttributes(this SmartAttributeDefinition definition, List<String> value)
        {
            definition.SetField("modifiedAttributes", value);
        }
    }
}