using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Vreugdenhil_prototype_7
{
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }

        async void RegisterButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterSucces());
        }
    }
}
