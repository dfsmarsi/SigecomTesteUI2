using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Threading;

namespace SigecomTestesUI
{
    public class ManipuladorService
    {
        private readonly WindowsDriver<WindowsElement> _driver;

        public ManipuladorService(WindowsDriver<WindowsElement> driver)
        {
            _driver = driver;
        }

        public void TrocarParaProximaJanela()
        {
            try
            {
                Thread.Sleep(TimeSpan.FromSeconds(2));
                var allWindowHandles = _driver.WindowHandles;

                if (allWindowHandles.Count > 0)
                {
                    _driver.SwitchTo().Window(allWindowHandles[0]);
                }
                else
                {
                    throw new WebDriverException("Não há janelas disponíveis para trocar.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao trocar de janela: {ex.Message}");
            }
        }

        public void TrocarParaProximaJanelaLogin()
        {
            try
            {
                Thread.Sleep(TimeSpan.FromSeconds(5));
                var allWindowHandles = _driver.WindowHandles;

                if (allWindowHandles.Count > 0)
                {
                    _driver.SwitchTo().Window(allWindowHandles[0]);
                }
                else
                {
                    throw new WebDriverException("Não há janelas disponíveis para trocar.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao trocar de janela: {ex.Message}");
            }
        }

        public WindowsElement EncontrarElementoId(string idElemento) =>
            _driver.FindElementByAccessibilityId(idElemento);

        public WindowsElement EncontrarElementoName(string nomeElemento) =>
            _driver.FindElementByName(nomeElemento);

        public WindowsElement EncontrarElementoXPath(string caminhoElemento) =>
            _driver.FindElementByXPath(caminhoElemento);

        public string ObterValorElementoId(string nomeElemento) =>
            _driver.FindElementByAccessibilityId(nomeElemento).Text;

        public string ObterValorElementoName(string nomeElemento) =>
            _driver.FindElementByName(nomeElemento).Text;

        public string PegarValorDaColunaDaGrid(string nomeColuna) =>
            _driver.FindElementByName($"{nomeColuna} row 0").Text;

        public string PegarValorDaColunaDaGridNaPosicao(string nomeColuna, string posicao) =>
            _driver.FindElementByName($"{nomeColuna} row {posicao}").Text;

        public void PreencherCampoTextoName(string nomeElemento, string valor)
        {
            var elemento = _driver.FindElementByName(nomeElemento);
            elemento.Clear();
            elemento.SendKeys(valor);
        }

        public void PreencherCampoTextoId(string idElemento, string valor)
        {
            var elemento = EncontrarElementoId(idElemento);
            elemento.Clear();
            elemento.SendKeys(valor);
        }

        public void ClicarNoBotaoName(string nomeElemento)
        {
            EncontrarElementoName(nomeElemento).Click();
        }

        public bool VerificarSePossuiOValorNaTela(string nome)
        {
            var driverPageSource = _driver.PageSource;
            return driverPageSource.Contains(nome);
        }

        public void ConfirmarSeElementoExisteName(string valor)
        {
            var elemento = EncontrarElementoName(valor);
            Assert.AreEqual(elemento.Text, valor);
        }

        public void EsperarAcaoEmSegundos(int tempoEmSegundos) =>
            Thread.Sleep(TimeSpan.FromSeconds(tempoEmSegundos));
    }
}
