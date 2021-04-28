using SolastaModApi.Infrastructure;
using System.Text;

namespace SolastaModApi
{
    public static class GuiQuestExtensions
    {
        public static T SetGameQuest<T>(this T entity, GameQuest value)
            where T : GuiQuest
        {
            entity.SetField("gameQuest", value);
            return entity;
        }

        public static T SetStringBuilder<T>(this T entity, StringBuilder value)
            where T : GuiQuest
        {
            entity.SetField("stringBuilder", value);
            return entity;
        }
    }
}