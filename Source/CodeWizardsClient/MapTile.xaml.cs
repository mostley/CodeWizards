using System.Windows.Media;

namespace CodeWizards.Client
{
    public partial class MapTile
    {
        public MapTile()
        {
            InitializeComponent();
        }

        public void SetBackground(ImageSource background)
        {
            BackgroundImage.Source = background;
        }
    }
}
