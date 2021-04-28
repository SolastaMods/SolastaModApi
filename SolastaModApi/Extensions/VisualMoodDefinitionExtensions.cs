using SolastaModApi.Infrastructure;
using UnityEngine.Rendering.PostProcessing;

namespace SolastaModApi
{
    public static class VisualMoodDefinitionExtensions
    {
        public static VisualMoodDefinition SetGlobalPostProcessProfile(this VisualMoodDefinition entity, PostProcessProfile value)
        {
            entity.SetField("globalPostProcessProfile", value);
            return entity;
        }

        public static VisualMoodDefinition SetRenderSettingsSceneProfile(this VisualMoodDefinition entity, RenderSettingsSceneProfile value)
        {
            entity.SetField("renderSettingsSceneProfile", value);
            return entity;
        }
    }
}