﻿namespace SigecomTestesUI.Sigecom.Cadastros
{
    public class EdicaoCadastroDeClienteFisicoSomenteCamposObrigatoriosDados
    {
        public string scriptCadastrarClienteSomenteCamposObrigatorios => "INSERT INTO Pessoa (CodigoClassificacao, CodigoTipo, Nome, CodigoNacionalidade, CodigoCidade, Desativado, BloquearLimite, ManterValorLimitePadrao, Bloquear_Cliente, LimiteVendas, ManterBloqueioPadrao, BloquearInadimplente, Mora, Multa, Carencia, Isenta_Juros, Juros_Automaticos_Padrao, Permitir_Venda_Prazo, Desconto_Padrao_Cliente, Enderecos) VALUES (1, 1, 'CLIENTE FISICO A EDITAR CAMPOS OBRIGATORIOS', 35, 1, 'N', 'N', 'S', 'N', 0, 'S', 'N', 0, 0, 0, 'N', 'S', 'S', 0, '');";
        public string nomeOriginalCliente => "CLIENTE FISICO A EDITAR CAMPOS OBRIGATORIOS";
        public string nomeAlteradoCliente => "CLIENTE FISICO ALTERADO CAMPOS OBRIGATORIOS";
        public string cidadeAlteradaCliente => "Uberlandia";
        public string estadoAlteradoCliente => "Minas Gerais";
    }
}
