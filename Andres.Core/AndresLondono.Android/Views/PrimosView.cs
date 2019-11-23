using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AndresLondono.Core.ViewModels;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Platforms.Android.Views;

namespace AndresLondono.Android.Views
{
    [Activity(Label = "PrimosView")]
    public class PrimosView : Activity
    {
        [Activity(Label = "@string/app_name")]
        public class FactorialView : MvxActivity<VerPrimosModel>
        {
            protected override void OnCreate(Bundle savedInstanceState)
            {
                base.OnCreate(savedInstanceState);
                SetContentView(Resource.Layout.PrimosPage);
            }
        }
    }
}