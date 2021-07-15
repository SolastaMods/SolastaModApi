using SolastaModApi;
using SolastaModApi.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolastaModApi.Definitions
{
    /// <summary>
    /// Definition for a feature that removes another feature - can come handy for replacement features for instance
    /// </summary>
    public class NegativeFeatureDefinition : FeatureDefinition
    {
        public FeatureDefinition FeatureToRemove;
    }

    /// <summary>
    /// Utility class for handling GUIDs for negative features
    /// </summary>
    public class NegativeFeatureUtility
    {
        private static Dictionary<string, string> featureToNegativeGuidDictionary;

        public static Dictionary<string, string> FeatureToNegativeGuidDictionary
        {
            get
            {
                if (featureToNegativeGuidDictionary == null)
                {
                    featureToNegativeGuidDictionary = new Dictionary<string, string>();
                }
                return featureToNegativeGuidDictionary;
            }
        }
    }

    /// <summary>
    /// To use NegativeFeatureBuilder on any feature, first add a new GUID for the negative feature in NegativeFeatureUtility.FeatureToNegativeGuidDictionary
    /// </summary>
    public class NegativeFeatureBuilder : BaseDefinitionBuilder<NegativeFeatureDefinition>
    {
        public NegativeFeatureBuilder(FeatureDefinition featureToRemove) : 
            base(
                $"{featureToRemove.Name}Negative",
                NegativeFeatureUtility.FeatureToNegativeGuidDictionary.ContainsKey(featureToRemove.GUID) 
                ? NegativeFeatureUtility.FeatureToNegativeGuidDictionary[featureToRemove.GUID] 
                : "")
        {
            Definition.FeatureToRemove = featureToRemove;
            Definition.GuiPresentation.SetHidden(true);
        }

        public static NegativeFeatureDefinition CreateAndAddToDB(FeatureDefinition featureToRemove)
            => new NegativeFeatureBuilder(featureToRemove).AddToDB();
    }
}
