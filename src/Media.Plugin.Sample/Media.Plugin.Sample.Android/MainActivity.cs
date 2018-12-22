
using Android.App;
using Android.Content.PM;
using Android.OS;
using Plugin.Permissions;
using System;

namespace Media.Plugin.Sample.Droid
{
	[Activity(Label = "Media.Plugin.Sample", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);
			try
			{
				global::Xamarin.Forms.Forms.Init(this, bundle);
				LoadApplication(new App());
			}
			catch(Exception exp)
			{

			}

		}


		public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
		{
			PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
		}
	}
}

