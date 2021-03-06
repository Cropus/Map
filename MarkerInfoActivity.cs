﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Map
{
    [Activity(Label = "Marker_Info_Activity")]
    public class MarkerInfoActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.marker_info);
            string geocodeAddress = Intent.GetStringExtra("geocode");
            string title = Intent.GetStringExtra("m_title");
            string radius = Intent.GetStringExtra("m_rad");
            TextView titleV = FindViewById<TextView>(Resource.Id.ttext1);
            TextView radiusV = FindViewById<TextView>(Resource.Id.ttext2);
            TextView addressV = FindViewById<TextView>(Resource.Id.ttext3);
            Button cancel = FindViewById<Button>(Resource.Id.ret_b);
            cancel.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };
            titleV.Text = title;
            radiusV.Text = radius;
            addressV.Text = geocodeAddress;
        }
    }
}