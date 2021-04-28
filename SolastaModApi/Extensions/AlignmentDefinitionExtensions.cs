using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class AlignmentDefinitionExtensions
    {
        public static T SetGoodnessAxis<T>(this T entity, int value)
            where T : AlignmentDefinition
        {
            entity.SetField("goodnessAxis", value);
            return entity;
        }

        public static T SetLawAxis<T>(this T entity, int value)
            where T : AlignmentDefinition
        {
            entity.SetField("lawAxis", value);
            return entity;
        }
    }
}