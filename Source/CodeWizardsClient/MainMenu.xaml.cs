using System.Windows;

namespace CodeWizards.Client
{
    using System;
    using System.ComponentModel;
    using System.Windows.Input;
    using System.Windows.Threading;

    public partial class MainMenu
    {
        private MainViewModel viewModel;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void OnClosed(object sender, EventArgs e)
        {
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void MainMenu_OnClosing(object sender, CancelEventArgs e)
        {
            Application.Current.Dispatcher.BeginInvoke(
                DispatcherPriority.Background,
                (DispatcherOperationCallback)delegate
                    {
                        Hide();
                        return null;
                    },
                null);

            e.Cancel = true;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            this.viewModel = (MainViewModel)this.DataContext;

            UsernameTextBox.Text = "Wizard " + new Random().Next(0, 100);
            UsernameTextBox.Focus();
            UsernameTextBox.SelectAll();
        }

        private void UsernameTextBox_OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                this.viewModel.Join(UsernameTextBox.Text);
            }
        }

        private void JoinClick(object sender, RoutedEventArgs e)
        {
            this.viewModel.Join(UsernameTextBox.Text);
        }
    }
}
