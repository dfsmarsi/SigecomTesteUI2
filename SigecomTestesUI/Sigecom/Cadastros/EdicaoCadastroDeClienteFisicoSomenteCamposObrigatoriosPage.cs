using OpenQA.Selenium.Appium.Windows;

namespace SigecomTestesUI.Sigecom.Cadastros
{
    public class EdicaoCadastroDeClienteFisicoSomenteCamposObrigatoriosPage : PageBase
    {
        public EdicaoCadastroDeClienteFisicoSomenteCamposObrigatoriosPage(WindowsDriver<WindowsElement> driver) : base(driver)
        {
        }

        private const string ElementoTelaCadastroCliente = "Cadastro de clientes";
        private const string BotaoMenuCadastro = "Cadastro";
        private const string BotaoSubMenuClientes = "Clientes";
        private const string BotaoNovo = "F2 - Novo";
        private const string BotaoGravar = "F5 - Gravar";
        private const string BotaoPesquisar = "F9 - Pesquisar";

        public void AcessarItemMenu()
        {
            _manipuladorService.DarDuploCliqueNoBotaoName(BotaoMenuCadastro);
        }

        public void AcessarItemSubMenu()
        {
            _manipuladorService.ClicarNoBotaoName(BotaoSubMenuClientes);
        }

        public void AbrirCadastroDoClienteASerAlterado()
        {
            _manipuladorService.ClicarNoBotaoName(BotaoNovo);
        }

        public void FecharTelaDeCadastroDeClienteEsc()
        {
            _manipuladorService.FecharJanelaComEscName(ElementoTelaCadastroCliente);
        }
    }
}
