using Prism;
using Prism.Ioc;
using NPhotos.ViewModels;
using NPhotos.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.Unity;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace NPhotos
{
    public partial class App : PrismApplication
    {
        /* 
* The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
* This imposes a limitation in which the App class must have a default constructor. 
* App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
*/
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/LoginPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<LoginPage>();
            containerRegistry.RegisterForNavigation<HomePage>();
        }

        public bool DoBack()
        {          
            NavigationPage mainPage = MainPage as NavigationPage;
            if (mainPage != null)
            {
                return mainPage.Navigation.NavigationStack.Count > 1;
            }
            return true;
            
        }
    }
}
