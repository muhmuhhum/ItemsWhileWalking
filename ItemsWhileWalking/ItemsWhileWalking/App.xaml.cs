using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ItemsWhileWalking
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
#if DEBUG
            HotReloader.Current.Run(this);
            //optionaly you may specify EXTENSION's IP (ExtensionIpAddress) 
            //in case your PC/laptop and device are in different subnets
            //e.g. 10.10.102.16 AND 10.10.9.12
#endif
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
