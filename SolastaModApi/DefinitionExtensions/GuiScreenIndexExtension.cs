using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class GuiScreenIndexExtensions
    {
        public static GuiScreenIndex SetGuiIndexSlots(this GuiScreenIndex definition, List<GuiScreenIndex.IndexSlot> value)
        {
            definition.SetField("guiIndexSlots", value);
            return definition;
        }
    }
}