using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Graphics;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;

namespace Cinestar2
{
    [Activity(
        Theme = "@style/Maui.SplashTheme",
        MainLauncher = true,
        LaunchMode = LaunchMode.SingleTop,
        ConfigurationChanges = ConfigChanges.ScreenSize
            | ConfigChanges.Orientation
            | ConfigChanges.UiMode
            | ConfigChanges.ScreenLayout
            | ConfigChanges.SmallestScreenSize
            | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

           
            Window.SetNavigationBarColor(
                Android.Graphics.Color.ParseColor("#CC051851")
            );
        }
    }
}
