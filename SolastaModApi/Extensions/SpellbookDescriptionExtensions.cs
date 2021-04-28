using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class SpellbookDescriptionExtensions
    {
        public static T SetPagesCapacity<T>(this T entity, int value)
            where T : SpellbookDescription
        {
            entity.SetField("pagesCapacity", value);
            return entity;
        }
    }
}