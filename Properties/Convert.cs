
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

namespace Converter
{
	[Activity (Label = "Convert")]			
	public class Convert : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView(Resource.Layout.Convert);
			// Create your application here
			Button button1 = FindViewById<Button> (Resource.Id.button1);
			Button button2 = FindViewById<Button> (Resource.Id.button2);
			Button button3 = FindViewById<Button> (Resource.Id.button3);
			Button button4 = FindViewById<Button> (Resource.Id.button4);
			Button button5 = FindViewById<Button> (Resource.Id.button5);
			Button button6 = FindViewById<Button> (Resource.Id.button6);
			Button button7 = FindViewById<Button> (Resource.Id.button7);
			Button button8 = FindViewById<Button> (Resource.Id.button8);
			Button button9 = FindViewById<Button> (Resource.Id.button9);
			Button button10 = FindViewById<Button> (Resource.Id.button10);
			Button button11 = FindViewById<Button> (Resource.Id.button11);
			Button button12 = FindViewById<Button> (Resource.Id.button12);
			button1.Click += delegate {
				var	mIntent = new Intent (this, typeof(Distance));
				StartActivity (mIntent);
			};
			button2.Click += delegate {
				var	mIntent = new Intent(this,typeof(Time));
				StartActivity(mIntent);
			};
			button3.Click += delegate {
				var	mIntent = new Intent(this,typeof(Pressure));
				StartActivity(mIntent);
			};
			button4.Click += delegate {
				var	mIntent = new Intent(this,typeof(Memory));
				StartActivity(mIntent);
			};
			button5.Click += delegate {
				var	mIntent = new Intent(this,typeof(Area));
				StartActivity(mIntent);
			};
			button6.Click += delegate {
				var	mIntent = new Intent (this, typeof(Mass));
				StartActivity (mIntent);
			};
			button7.Click += delegate {
				var	mIntent = new Intent (this, typeof(Speed));
				StartActivity (mIntent);
			};
			button8.Click += delegate {
				var	mIntent = new Intent (this, typeof(DataRate));
				StartActivity (mIntent);
			};
			button9.Click += delegate {
				var	mIntent = new Intent(this,typeof(Volume));
				StartActivity(mIntent);
			};
			button10.Click += delegate {
				var	mIntent = new Intent(this,typeof(Power));
				StartActivity(mIntent);
			};
			button11.Click += delegate {
				var	mIntent = new Intent(this,typeof(SpeedUp));
				StartActivity(mIntent);
			};
			button12.Click += delegate {
				var	mIntent = new Intent(this,typeof(DownloadSpeed));
				StartActivity(mIntent);
			};
		}
	}
}

