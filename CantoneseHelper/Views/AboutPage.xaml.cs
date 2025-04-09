using Microsoft.UI.Xaml.Controls;
using Windows.ApplicationModel;

namespace CantoneseHelper.Views
{
        public sealed partial class AboutPage : Page
        {
                public AboutPage()
                {
                        this.InitializeComponent();
                        var version = Package.Current.Id.Version;
                        string versionText = $"{version.Major}.{version.Minor}.{version.Build}.{version.Revision}";
                        AppVersionTextBlock.Text = versionText;
                }
        }
}
