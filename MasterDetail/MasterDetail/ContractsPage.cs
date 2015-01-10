using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace MasterDetail
{

    public class ContractsPage : RootPage
    {
        public ContractsPage()
            : base()
        {
            Title = "Contracts";
            Icon = "Contracts.png";
            this.Detail = new ContentPage()
            {
                Content = new StackLayout
                {
                    // change this however you need
                    Children =
                                              {
                                                  new Label { Text = "This is the contract page" },
                                                  new Button { Text = "Ok" },
                                              }
                }

            };
        }
    }

}