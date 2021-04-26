using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class SmartAttributeDefinitionExtensions
    {
        public static T SetModifiedAttributes<T>(this T definition, List<string> value)
            where T : SmartAttributeDefinition
        {
            definition.SetField("modifiedAttributes", value);
            return definition;
        }
    }
}