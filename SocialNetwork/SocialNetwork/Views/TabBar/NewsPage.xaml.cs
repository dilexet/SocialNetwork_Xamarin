using System;
using SocialNetwork.Converters;
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
            Resources.Add("BackgroundColorConverter", new BackgroundColorConverter());
            NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetHasNavigationBar(this, false);
            _mockDataStore = new MockDataStore();
        }

        protected async override void OnAppearing()
        {
            NewsView.ItemsSource = await _mockDataStore.GetNews();
            base.OnAppearing();
        }

        private void MaterialFloatingButton_OnClicked(object sender, EventArgs e)
        {
            
        }
    }
}