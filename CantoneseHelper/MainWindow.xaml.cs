using CantoneseHelper.Views;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace CantoneseHelper
{
        public sealed partial class MainWindow : Window
        {
                public MainWindow()
                {
                        this.InitializeComponent();
                        ContentFrame.Navigate(typeof(SearchPage));
                }
                private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
                {
                        var selectedTag = args.SelectedItemContainer.Tag.ToString();
                        switch (selectedTag)
                        {
                                case "CantoneseHelper.Views.InitialsPage":
                                        ContentFrame.Navigate(typeof(InitialsPage));
                                        break;
                                case "CantoneseHelper.Views.FinalsPage":
                                        ContentFrame.Navigate(typeof(FinalsPage));
                                        break;
                                case "CantoneseHelper.Views.TonesPage":
                                        ContentFrame.Navigate(typeof(TonesPage));
                                        break;
                                case "CantoneseHelper.Views.ResourcesPage":
                                        ContentFrame.Navigate(typeof(ResourcesPage));
                                        break;
                                case "CantoneseHelper.Views.AboutPage":
                                        ContentFrame.Navigate(typeof(AboutPage));
                                        break;
                                default:
                                        ContentFrame.Navigate(typeof(SearchPage));
                                        break;
                        }
                }
        }
}
