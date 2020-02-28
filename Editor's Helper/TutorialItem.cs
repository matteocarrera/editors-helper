using System.Drawing;

namespace Editor_Helper
{
    public class TutorialItem
    {
        public string Text { get; private set; }
        public Bitmap Image { get; private set; }

        public TutorialItem(string text, Bitmap image)
        {
            Text = text;
            Image = image;
        }
    }
}
