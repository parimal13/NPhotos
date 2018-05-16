using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Widget;
using Prism;
using Prism.Ioc;
namespace NPhotos.Droid
{
    [Activity(Label = "NPhotos", Theme = "@style/MainTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        App _app;
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);
           
            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App(new AndroidInitializer()));
            _app = new App();
            Window.SetStatusBarColor(this.Resources.GetColor(Resource.Color.appMajorColor));
        }

       /* public override void OnBackPressed()
        {
            if (_app.DoBack())
            {
                base.OnBackPressed();
            }
        } */
    }

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainerRegistry container)
        {
            // Register any platform specific implementations
        }
    }
}

