using OpenQA.Selenium.Appium.Windows;
using System;

namespace SigecomTestesUI
{
    public class LoginPage
    {
        private readonly ManipuladorService _manipuladorService;

        public LoginPage(WindowsDriver<WindowsElement> driver)
        {
            _manipuladorService = new ManipuladorService(driver);
        }

        private const string NomeCampoUsuario = "txtUsuario";
        private const string NomeCampoSenha = "txtSenha";
        private const string NomeBotaoAcessar = ", Acessar";
        private const string NomeFrmPrincipal = "SIGECOM - Sistema de Gestão Comercial - SISTEMASBR";

        public void RealizarLogin(LoginDados dadosLogin)
        {
            try
            {
                _manipuladorService.PreencherCampoTextoId(NomeCampoUsuario, dadosLogin.Usuario);
                _manipuladorService.PreencherCampoTextoId(NomeCampoSenha, dadosLogin.Senha);
                _manipuladorService.ClicarNoBotaoName(NomeBotaoAcessar);
                _manipuladorService.TrocarParaProximaJanelaLogin();
                ValidarSeLoginFoiRealizado();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao fazer login: {ex.Message}");
            }
        }

        private void ValidarSeLoginFoiRealizado()
        {
            _manipuladorService.ObterValorElementoName(NomeFrmPrincipal).Equals(NomeFrmPrincipal);
        }
    }
}
