using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class GuiScreenIndexExtensions
    {
        public static T SetGuiIndexSlots<T>(this T definition, List<GuiScreenIndex.IndexSlot> value)
            where T : GuiScreenIndex
        {
            definition.SetField("guiIndexSlots", value);
            return definition;
        }
    }
}