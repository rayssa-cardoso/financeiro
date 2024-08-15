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

        private void OnTelaFornecedorClicked(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new CadastrodoFornecedor();
        }

        private void OnGerenciaFornecedorClicked(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new GerenciaFornecedor();
        }

         private void OnGerenciaMateriaisClicked(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new GerenciaMateriais();
        }

        private void OnGerenciaGastosClicked(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new GerenciaGastos();
        }

         private void OnGerenciaEstoqueClicked(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new GerenciaEstoque();
        }
    }

}




