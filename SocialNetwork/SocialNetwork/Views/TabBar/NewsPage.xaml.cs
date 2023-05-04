using SocialNetwork.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SocialNetwork.Views.TabBar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsPage : ContentPage
    {
        private readonly MockDataStore _mockDataStore;

        public NewsPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            _mockDataStore = new MockDataStore();
        }

        protected async override void OnAppearing()
        {
            NewsView.ItemsSource = await _mockDataStore.GetNews();
            base.OnAppearing();
        }
    }
}