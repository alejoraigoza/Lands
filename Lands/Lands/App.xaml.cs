using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Lands
{
    using Xamarin.Forms;
    using Views;

    public partial class App : Application
	{

        #region constructors
        public App ()
		{
			InitializeComponent();

			MainPage = new LoginPage();
		}
        #endregion

        #region methods
        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
            // Handle when your app resumes

        }
        #endregion
    }

}
