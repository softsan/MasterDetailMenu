using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace MasterDetail
{

    public class LeadsPage : RootPage
    {
        public LeadsPage()
            : base()
        {
            Title = "Leads";
            Icon = "Leads.png";
            this.Detail = new ContentPage()
            {
                Content = new StackLayout
                {
                    // change this however you need
                    Children =
                                              {
                                                  new Label { Text = "This is the second page" },
                                                  new Button { Text = "Ok" },
                                              }
                }

            };
        }
    }

}