using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Vreugdenhil_prototype_7
{
    public partial class RegisterSucces : ContentPage
    {
        public RegisterSucces()
        {
            InitializeComponent();
        }

        async void ToLogin_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
