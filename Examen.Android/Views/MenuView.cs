using Android;
using Android.App;
using Android.OS;
using Examen.Core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace Examen.Android.Views
{
    [Activity(Label = "@string/app_name")]
    public class MenuView : MvxActivity<MenuViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MenuPage);
        }
    }
}