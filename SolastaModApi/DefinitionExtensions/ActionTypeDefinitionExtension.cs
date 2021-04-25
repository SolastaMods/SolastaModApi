using SolastaModApi.Infrastructure;
using UnityEngine;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class ActionTypeDefinitionExtensions
    {
        public static void SetColor(this ActionTypeDefinition definition, Color value)
        {
            definition.SetField("color", value);
        }

        public static void SetUnavailableColor(this ActionTypeDefinition definition, Color value)
        {
            definition.SetField("unavailableColor", value);
        }
    }
}