using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class LootableContainerDefinitionExtensions
    {
        public static T SetContentAlwaysKnown<T>(this T definition, bool value)
            where T : LootableContainerDefinition
        {
            definition.SetField("contentAlwaysKnown", value);
            return definition;
        }

        public static T SetForbidDrop<T>(this T definition, bool value)
            where T : LootableContainerDefinition
        {
            definition.SetField("forbidDrop", value);
            return definition;
        }

        public static T SetIgnoredByScavengers<T>(this T definition, bool value)
            where T : LootableContainerDefinition
        {
            definition.SetField("ignoredByScavengers", value);
            return definition;
        }

        public static T SetMinSlotsNumber<T>(this T definition, int value)
            where T : LootableContainerDefinition
        {
            definition.SetField("minSlotsNumber", value);
            return definition;
        }
    }
}