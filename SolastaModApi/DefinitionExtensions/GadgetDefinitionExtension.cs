using SolastaModApi.Infrastructure;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class GadgetDefinitionExtensions
    {
        public static void SetArmorClass(this GadgetDefinition definition, Int32 value)
        {
            definition.SetField("armorClass", value);
        }
    }
}