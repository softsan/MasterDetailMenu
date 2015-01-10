using System;
using Xamarin.Forms;

namespace MasterDetail
{
	public class App
	{
        public static INavigation Navigation;
		public static Page GetMainPage ()
		{
            var p = new NavigationPage(new HomePage());
		    App.Navigation = p.Navigation;
		    return p;//  new NavigationPage(new HomePage());

		}
	}
}