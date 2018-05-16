
using Android.App;
using Android.OS;

namespace NPhotos.Droid
{
    [Activity(Label = "NPhotos",Icon ="@drawable/icon",NoHistory =true, MainLauncher =true,Theme = "@style/SplashStyle")]
    public class SplashScreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(typeof(MainActivity));
        }
    }
}