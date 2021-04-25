using SolastaModApi.Infrastructure;
using UnityEngine;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class ActionTypeDefinitionExtensions
    {
        public static ActionTypeDefinition SetColor(this ActionTypeDefinition definition, Color value)
        {
            definition.SetField("color", value);
            return definition;
        }

        public static ActionTypeDefinition SetColor(this ActionTypeDefinition definition, Color value)
        {
            definition.SetField("unavailableColor", value);
            return definition;
        }
    }
}