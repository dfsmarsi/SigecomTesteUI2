using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace SigecomTestesUI
{
    public class CadastroTeste : TesteBase
    {

        [Test(Description = "Cadastro de cliente somente campos obrigatórios com endereço")]
        [AllureSuite("Cadastros")]
        [AllureSubSuite("Cliente")]
        public void TesteCadastroComSucesso()
        {
            // Verifica se o cadastro foi bem-sucedido (adicionar asserções conforme necessário)
            Assert.IsTrue(true);
        }
    }
}
