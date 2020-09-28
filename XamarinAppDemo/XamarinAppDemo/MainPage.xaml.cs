using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace XamarinAppDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void FirstPageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FirstPage());
        }

        private void StackLayoutPageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StackLayoutPage());
        }

        private void GridPageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridPage());
        }
    }
}
