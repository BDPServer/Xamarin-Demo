using DemoApp.Services;
using DemoApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            this.BindingContext = new MainPageViewModel(new RestService(),this);
		}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }
    }
}
