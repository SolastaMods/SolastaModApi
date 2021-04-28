using UnityEngine;
using UnityEngine.AddressableAssets;

namespace SolastaModApi
{
    public class GuiPresentationBuilder
    {
        private readonly GuiPresentation guiPresentation;

        public GuiPresentationBuilder(string description, string title)
        {
            guiPresentation = new GuiPresentation
            {
                Description = description,
                Title = title
            };

            SetSpriteReference(new AssetReferenceSprite(""));
        }

        public void SetColor(Color color) => guiPresentation.SetColor(color);

        public void SetSortOrder(int sortOrder) => guiPresentation.SetSortOrder(sortOrder);

        public void SetSpriteReference(AssetReferenceSprite sprite) => guiPresentation.SetSpriteReference(sprite);

        public GuiPresentation Build()
        {
            return guiPresentation;
        }
    }
}
