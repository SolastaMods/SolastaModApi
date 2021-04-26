using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class GadgetDefinitionExtensions
    {
        public static T SetArmorClass<T>(this T definition, int value)
            where T : GadgetDefinition
        {
            definition.SetField("armorClass", value);
            return definition;
        }
    }
}