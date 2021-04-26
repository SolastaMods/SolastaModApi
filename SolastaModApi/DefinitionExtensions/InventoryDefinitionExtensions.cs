using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class InventoryDefinitionExtensions
    {
        public static T SetSlotsMap<T>(this T definition, List<InventoryDefinition.SlotPair> value)
            where T : InventoryDefinition
        {
            definition.SetField("slotsMap", value);
            return definition;
        }
    }
}