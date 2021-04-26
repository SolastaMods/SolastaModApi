using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class DatabaseIndexExtensions
    {
        public static T SetDatabaseIndexSlots<T>(this T definition, List<DatabaseIndex.IndexSlot> value)
            where T : DatabaseIndex
        {
            definition.SetField("databaseIndexSlots", value);
            return definition;
        }
    }
}