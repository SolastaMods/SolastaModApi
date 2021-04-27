using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class AlignmentDefinitionExtensions
    {
        public static T SetGoodnessAxis<T>(this T definition, int value)
            where T : AlignmentDefinition
        {
            definition.SetField("goodnessAxis", value);
            return definition;
        }

        public static T SetLawAxis<T>(this T definition, int value)
            where T : AlignmentDefinition
        {
            definition.SetField("lawAxis", value);
            return definition;
        }
    }
}