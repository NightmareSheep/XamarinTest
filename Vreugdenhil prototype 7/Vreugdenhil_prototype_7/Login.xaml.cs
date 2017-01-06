using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Vreugdenhil_prototype_7
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        async void OnRegister(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Register());
        }

        async void LoginButtuon_OnClicked(object sender, EventArgs e)
        {
            Navigation.InsertPageBefore(new MainPage(), this);
            await Navigation.PopAsync();
        }
    }
}
