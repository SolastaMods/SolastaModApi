using SolastaModApi.Infrastructure;
using UnityEngine.Rendering.PostProcessing;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class VisualMoodDefinitionExtensions
    {
        public static void SetGlobalPostProcessProfile(this VisualMoodDefinition definition, PostProcessProfile value)
        {
            definition.SetField("globalPostProcessProfile", value);
        }

        public static void SetRenderSettingsSceneProfile(this VisualMoodDefinition definition, RenderSettingsSceneProfile value)
        {
            definition.SetField("renderSettingsSceneProfile", value);
        }
    }
}