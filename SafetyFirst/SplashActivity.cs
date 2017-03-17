using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace SafetyFirst
{
    [Activity(Label = "SplashActivity", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class SplashActivity : AppCompatActivity
    {
        private ImageView splashScreen;
        private ProgressBar progressBar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SplashScreen);
            splashScreen = FindViewById<ImageView>(Resource.Id.image);
            progressBar = FindViewById<ProgressBar>(Resource.Id.progressBar);

            Timer timer = new Timer();
            timer.Interval = 3000;
            timer.AutoReset = false;
            timer.Elapsed += TimerOnElapsed;
            timer.Start();
            // Create your application here
        }

        private void TimerOnElapsed(object sender, ElapsedEventArgs elapsedEventArgs)
        {
            StartActivity(new Intent(this, typeof(HomeActivity)));
        }
    }
}