using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace SigecomTestesUI.Sigecom.Cadastros
{
    public class EdicaoCadastroDeClienteFisicoSomenteCamposObrigatoriosTeste : TesteBase
    {

        [Test(Description = "Edição de cadastro de cliente somente campos obrigatórios")]
        [AllureSuite("Cadastros")]
        [AllureSubSuite("Cliente")]
        public void TesteCadastroComSucesso()
        {
            var dados = new EdicaoCadastroDeClienteFisicoSomenteCamposObrigatoriosDados();

            var db = new AcessoDB();
            var consulta = db.RealizarConsulta($"SELECT * FROM pessoa WHERE nome = '{dados.nomeOriginalCliente}' AND codigotipo = 1;");
            if(consulta.Rows.Count == 0) {
                db.ExecutarScript(dados.scriptCadastrarClienteSomenteCamposObrigatorios);
            }

            var page = new EdicaoCadastroDeClienteFisicoSomenteCamposObrigatoriosPage(Driver);
            page.AcessarItemMenu();
            page.AcessarItemSubMenu();
            ManipuladorService.EsperarAcaoEmSegundos(2);
            page.AbrirCadastroDoClienteASerAlterado();
            page.FecharTelaDeCadastroDeClienteEsc();
        }
    }
}
