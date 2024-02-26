﻿using SigecomTestesUI.Config;
using SigecomTestesUI.Services;

namespace SigecomTestesUI.Sigecom.Cadastros.Pessoas.PesquisaPessoa
{
    public class PesquisaDePessoaPage : PageObjectModel
    {
        private const string _telaPesquisaPessoaPrefixo = "Pesquisa de ";
        private const string _elementoParametroDePesquisa = "textEditParametroDePesquisa";

        public PesquisaDePessoaPage(DriverService driver) : base(driver) { }

        public void PesquisarPessoa(string tipoPessoa, string nomePessoa)
        {
            DriverService.ValidarElementoExistentePorNome(_telaPesquisaPessoaPrefixo + tipoPessoa);
            DriverService.DigitarNoCampoEnterId(_elementoParametroDePesquisa, nomePessoa);            
        }

        public bool VerificarSeExistePessoaNaGrid(string nomePessoa)
        {
            var nomePessoaNaGrid = DriverService.PegarValorDaColunaDaGrid("Nome");
            if (nomePessoa == nomePessoaNaGrid)
                return true;
            return false;
        }

        public bool FecharJanelaComEsc(string tipoPessoa)
        {
            var nomeJanela = _telaPesquisaPessoaPrefixo + tipoPessoa;
            try
            {
                DriverService.FecharJanelaComEsc(nomeJanela);

                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}
