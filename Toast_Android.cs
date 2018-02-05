using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App2.Droid;
using Xamarin.Forms;

[assembly:Dependency(typeof(Toast_Android))]
namespace App2.Droid
{
    class Toast_Android : IToast
    {
        public void show(string msg)
        {
            Android.Widget.Toast.MakeText(Android.App.Application.Context,msg,ToastLength.Long).Show();
        }
    }
}