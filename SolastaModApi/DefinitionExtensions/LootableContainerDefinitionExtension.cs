using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class LootableContainerDefinitionExtensions
    {
        public static void SetContentAlwaysKnown(this LootableContainerDefinition definition, Boolean value)
        {
            definition.SetField("contentAlwaysKnown", value);
        }

        public static void SetForbidDrop(this LootableContainerDefinition definition, Boolean value)
        {
            definition.SetField("forbidDrop", value);
        }

        public static void SetIgnoredByScavengers(this LootableContainerDefinition definition, Boolean value)
        {
            definition.SetField("ignoredByScavengers", value);
        }

        public static void SetMinSlotsNumber(this LootableContainerDefinition definition, Int32 value)
        {
            definition.SetField("minSlotsNumber", value);
        }

        public static void SetRestrictedItems(this LootableContainerDefinition definition, List<ItemDefinition> value)
        {
            definition.SetField("restrictedItems", value);
        }
    }
}