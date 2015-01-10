using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace MasterDetail
{

	public class MenuListData : List<MenuItem>
	{
		public MenuListData ()
		{
            this.Add(new MenuItem()
            {
                Title = "Home",
                TargetType = typeof(HomePage)
            });

			this.Add (new MenuItem () { 
				Title = "Contracts", 
				TargetType = typeof(ContractsPage)
			});

			this.Add (new MenuItem () { 
				Title = "Leads", 
				TargetType = typeof(LeadsPage)
			});

			this.Add (new MenuItem () { 
				Title = "About",
                TargetType = typeof(AboutPage)
			});

			
		}
	}
}