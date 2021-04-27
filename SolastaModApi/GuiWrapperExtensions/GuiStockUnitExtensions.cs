using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class GuiStockUnitExtensions
    {
        public static T SetStockUnit<T>(this T entity, GameStockUnit value)
            where T : GuiStockUnit
        {
            entity.SetField("stockUnit", value);
            return entity;
        }
    }
}