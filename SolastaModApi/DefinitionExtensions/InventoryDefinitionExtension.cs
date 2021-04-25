using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class InventoryDefinitionExtensions
    {
        public static void SetSlotsMap(this InventoryDefinition definition, List<InventoryDefinition.SlotPair> value)
        {
            definition.SetField("slotsMap", value);
        }
    }
}