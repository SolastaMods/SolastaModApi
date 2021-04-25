using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class DatabaseIndexExtensions
    {
        public static void SetDatabaseIndexSlots(this DatabaseIndex definition, List<DatabaseIndex.IndexSlot> value)
        {
            definition.SetField("databaseIndexSlots", value);
        }
    }
}