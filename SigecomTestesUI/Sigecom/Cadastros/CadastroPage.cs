using OpenQA.Selenium.Appium.Windows;

namespace SigecomTestesUI
{
    public class CadastroPage
    {
        private readonly ManipuladorService _manipuladorService;

        public CadastroPage(WindowsDriver<WindowsElement> driver)
        {
            _manipuladorService = new ManipuladorService(driver);
        }

        // Mapeamento dos elementos da tela de cadastro
        private const string NomeElementoCampoNome = "campoNome";
        private const string NomeElementoCampoEmail = "campoEmail";
        private const string NomeElementoBotaoCadastrar = "botaoCadastrar";

        // Método para preencher o campo de nome
        public void PreencherCampoNome(string nome)
        {
            //_manipuladorService.PreencherCampoTexto(NomeElementoCampoNome, nome);
        }

        // Método para preencher o campo de e-mail
        public void PreencherCampoEmail(string email)
        {
           // _manipuladorService.PreencherCampoTexto(NomeElementoCampoEmail, email);
        }

        // Método para clicar no botão de cadastrar
        public void ClicarBotaoCadastrar()
        {
            //_manipuladorService.ClicarBotao(NomeElementoBotaoCadastrar);
        }

    }
}
