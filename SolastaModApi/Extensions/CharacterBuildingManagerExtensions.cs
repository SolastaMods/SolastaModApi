using HarmonyLib;
using System.Collections.Generic;
using SolastaModApi.Definitions;

namespace SolastaModApi.Extensions
{
    public class CharacterBuildingManagerExtensions
    {
        // This extension makes the CharacterBuildingManager.GrantFeaturesPatch take in account "negative features" that remove existing features
        [HarmonyPatch(typeof(CharacterBuildingManager), "GrantFeatures")]
        class GrantFeaturesPatch
        {
            static void Prefix(CharacterBuildingManager __instance, List<FeatureDefinition> grantedFeatures)
            {
                foreach (FeatureDefinition grantedFeature in grantedFeatures)
                {
                    NegativeFeatureDefinition negativeFeature = grantedFeature as NegativeFeatureDefinition;

                    if (negativeFeature == null || negativeFeature.FeatureToRemove == null)
                    {
                        continue;
                    }
                    
                    foreach (KeyValuePair<string, List<FeatureDefinition>> tagFeatures in __instance.HeroCharacter.ActiveFeatures)
                    {
                        tagFeatures.Value.RemoveAll(feature => feature.GUID.Equals(negativeFeature.FeatureToRemove.GUID) && feature.Name.Equals(negativeFeature.FeatureToRemove.Name));
                    }
                }
            }
        }
    }
}
