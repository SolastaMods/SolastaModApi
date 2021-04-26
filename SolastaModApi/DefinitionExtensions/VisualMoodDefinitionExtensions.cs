using SolastaModApi.Infrastructure;
using UnityEngine.Rendering.PostProcessing;

namespace SolastaModApi
{
    public static class VisualMoodDefinitionExtensions
    {
        public static VisualMoodDefinition SetGlobalPostProcessProfile<T>(this VisualMoodDefinition definition, PostProcessProfile value)
        {
            definition.SetField("globalPostProcessProfile", value);
            return definition;
        }

        public static VisualMoodDefinition SetRenderSettingsSceneProfile<T>(this VisualMoodDefinition definition, RenderSettingsSceneProfile value)
        {
            definition.SetField("renderSettingsSceneProfile", value);
            return definition;
        }
    }
}