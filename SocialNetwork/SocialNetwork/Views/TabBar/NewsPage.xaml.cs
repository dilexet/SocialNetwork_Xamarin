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
        private readonly NewsMockDataStore _newsMockDataStore;

        public NewsPage()
        {
            InitializeComponent();
            Resources.Add("BackgroundColorConverter", new BackgroundColorConverter());
            _newsMockDataStore = new NewsMockDataStore();
        }

        protected async override void OnAppearing()
        {
            NewsView.ItemsSource = await _newsMockDataStore.GetNews();
            base.OnAppearing();
        }

        private void MaterialFloatingButton_OnClicked(object sender, EventArgs e)
        {
            
        }
    }
}