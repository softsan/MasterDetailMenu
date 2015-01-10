using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace MasterDetail
{

    public class AboutPage : RootPage
    {
        public AboutPage()
            : base()
        {
            Title = "AboutPage";
            this.Detail = new ContentPage()
            {
                Content = new StackLayout
                {
                    // change this however you need
                    Children =
                                              {
                                                  new Label { Text = "This is the about page" },
                                                  new Button { Text = "Ok" },
                                              }
                }

            };
        }
    }

}