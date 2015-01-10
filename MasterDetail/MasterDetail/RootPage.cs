using System;
using Xamarin.Forms;
using System.Linq;

namespace MasterDetail
{
	public class RootPage : MasterDetailPage
	{
		public RootPage () :base()
		{
			var menuPage = new MenuPage ();

			menuPage.Menu.ItemSelected += (sender, e) => NavigateTo (e.SelectedItem as MenuItem);

			Master = menuPage;
		}

		void NavigateTo (MenuItem menu)
		{
            Page displayPage = (Page)Activator.CreateInstance (menu.TargetType);
            IsPresented = false;
		    var p = new NavigationPage(displayPage);
            Navigation.PushAsync(p);
		}
	}

}