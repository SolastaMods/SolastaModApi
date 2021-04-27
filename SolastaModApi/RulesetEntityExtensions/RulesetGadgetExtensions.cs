using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class RulesetGadgetExtensions
    {
        public static T SetGadgetDefinition<T>(this T entity, GadgetDefinition value)
            where T : RulesetGadget
        {
            entity.SetField("gadgetDefinition", value);
            return entity;
        }
    }
}