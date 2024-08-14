using Microsoft.Maui.Controls;

namespace lupafinance
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void OnTelaCadastroClicked(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new CadastroCliente();
        }


    }



}




