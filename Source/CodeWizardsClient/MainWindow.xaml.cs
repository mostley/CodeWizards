namespace CodeWizards.Client
{
    using System.Windows;
    using System.Windows.Input;

    public partial class MainWindow
    {
        private readonly MainViewModel viewModel;
        private MainMenu mainMenu;

        public MainWindow()
        {
            this.InitializeComponent();

            this.viewModel = new MainViewModel();
            this.DataContext = this.viewModel;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            this.mainMenu = new MainMenu
                                {
                                    Owner = this,
                                    DataContext = this.DataContext
                                };
            this.mainMenu.ShowDialog();
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                this.mainMenu.ShowDialog();
            }
        }
    }
}
