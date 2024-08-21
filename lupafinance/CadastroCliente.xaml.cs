using Microsoft.Maui.Controls;

namespace lupafinance
{
    public partial class CadastroCliente : ContentPage
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void OnVoltarButtom(object sender, EventArgs e)
        {
           Application.Current.MainPage = new MainPage();
        }
    }
}
