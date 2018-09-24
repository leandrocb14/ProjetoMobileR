using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoMobile.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PedidoView : ContentPage
	{
		public PedidoView ()
		{
			InitializeComponent ();
		}
        protected override void OnDisappearing()
        {
            base.OnDisappearing();            
        }
    }
}