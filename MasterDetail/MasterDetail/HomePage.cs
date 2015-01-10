using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace MasterDetail
{

    public class HomePage : RootPage
    {
        public HomePage()
            : base()
        {
            Title = "HomePage";
            Icon = "Opportunities.png";
            this.Detail = new ContentPage()
                              { 
                                Content = new StackLayout
                                      {
                                          // change this however you need
                                          Children =
                                              {
                                                  new Label { Text = "This is the Home page" },
                                                  new Button { Text = "Ok" },
                                              }
                                      }
                              
                              };
        }
    }
}