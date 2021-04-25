using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class GadgetDefinitionExtensions
    {
        public static GadgetDefinition SetArmorClass(this GadgetDefinition definition, int value)
        {
            definition.SetField("armorClass", value);
            return definition;
        }
    }
}