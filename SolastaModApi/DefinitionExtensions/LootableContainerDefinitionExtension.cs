using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class LootableContainerDefinitionExtensions
    {
        public static LootableContainerDefinition SetContentAlwaysKnown(this LootableContainerDefinition definition, bool value)
        {
            definition.SetField("contentAlwaysKnown", value);
            return definition;
        }

        public static LootableContainerDefinition SetForbidDrop(this LootableContainerDefinition definition, bool value)
        {
            definition.SetField("forbidDrop", value);
            return definition;
        }

        public static LootableContainerDefinition SetIgnoredByScavengers(this LootableContainerDefinition definition, bool value)
        {
            definition.SetField("ignoredByScavengers", value);
            return definition;
        }

        public static LootableContainerDefinition SetMinSlotsNumber(this LootableContainerDefinition definition, int value)
        {
            definition.SetField("minSlotsNumber", value);
            return definition;
        }

        public static LootableContainerDefinition SetRestrictedItems(this LootableContainerDefinition definition, List<ItemDefinition> value)
        {
            definition.SetField("restrictedItems", value);
            return definition;
        }
    }
}