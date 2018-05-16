using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NPhotos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void SignInwithGoogle(object o, EventArgs eventArg)
        {
            await Navigation.PushAsync(new GoogleProfileCsPage());
           // await Navigation.PushAsync(new HomePage());
            Navigation.RemovePage(this);
        }
    }
}
