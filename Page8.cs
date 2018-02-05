using Plugin.Toasts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App2
{
	public class Page8 : ContentPage
	{
		public Page8 ()
		{
            Button showToast = new Button { Text = "Show Toast" };



            showToast.Clicked += (s, e) =>

            {
                DependencyService.Get<IToast>().show("i am a simple toast");
            };



            // The root page of your application

            
                Content = new StackLayout

                {

                    VerticalOptions = LayoutOptions.Center,

                    Children = {

                        showToast

                    }

                 };



        }

     


    }
	}
