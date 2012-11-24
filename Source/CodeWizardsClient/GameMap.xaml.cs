using System.Windows;

namespace CodeWizards.Client
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Media;

    public partial class GameMap
    {
        public static readonly DependencyProperty WorldDataProperty = DependencyProperty.Register("WorldData", typeof(WorldData), typeof(GameMap), new PropertyMetadata(default(WorldData), OnWorldDataChanged));

        public static readonly DependencyProperty GrasImageProperty =
            DependencyProperty.Register("GrasImage", typeof(ImageSource), typeof(GameMap), new PropertyMetadata(default(ImageSource)));

        private List<List<MapTile>> tiles;

        private static void OnWorldDataChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
            ((GameMap)dependencyObject).UpdateMap();
        }

        public GameMap()
        {
            InitializeComponent();
        }

        public ImageSource GrasImage
        {
            get
            {
                return (ImageSource)this.GetValue(GrasImageProperty);
            }
            set
            {
                this.SetValue(GrasImageProperty, value);
            }
        }

        public WorldData WorldData
        {
            get
            {
                return (WorldData)GetValue(WorldDataProperty);
            }
            set
            {
                SetValue(WorldDataProperty, value);
            }
        }

        private void UpdateMap()
        {
            if (MapGrid.Children.Count == 0)
            {
                InitGrid();
            }
        }

        private void InitGrid()
        {
            tiles = new List<List<MapTile>>();
            for (int y = 0; y < WorldData.Ground.Count; y++)
            {
                tiles.Add(new List<MapTile>());

                for (int x = 0; x < WorldData.Ground[y].Count; x++)
                {
                    var groundType = WorldData.Ground[y][x];
                    var mapTile = new MapTile();
                    tiles[y].Add(mapTile);
                    MapGrid.Children.Add(mapTile);

                    switch (groundType)
                    {
                        case GroundType.Gras:
                            mapTile.SetBackground(GrasImage);
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
            }
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
