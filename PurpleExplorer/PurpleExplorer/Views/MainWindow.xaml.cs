using System.Collections.ObjectModel;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using PurpleExplorer.Helpers;
using PurpleExplorer.Models;
using PurpleExplorer.ViewModels;
using DynamicData;
using PurpleExplorer.Models;
using PurpleExplorer.ViewModels;

namespace PurpleExplorer.Views
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private async void TreeView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var mainWindowViewModel = this.DataContext as MainWindowViewModel;
            var treeView = sender as TreeView;
            if (treeView.SelectedItem is ServiceBusSubscription)
            {
                var selectedItem = treeView.SelectedItem as ServiceBusSubscription;
                await mainWindowViewModel.SetSubscripitonMessages(selectedItem);
            }

        }
    }
}