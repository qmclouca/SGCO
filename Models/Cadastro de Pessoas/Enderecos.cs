using System;

namespace CadastroPessoas
{
	public class Enderecos
	{
		public Int64 OId { get; set; }
		public String logradouro1 { get; set; }
		public String logradouro2 { get; set; }
		public Int16 numero1 { get; set; }
		public Int16 numero2 { get; set; }
		public String cidade1 { get; set; }
		public String cidade2 { get; set; }
		public String bairro1 { get; set; }
		public String bairro2 { get; set; }
		public String cep1 { get; set; }
		public String cep2 { get; set; }
		public DadosCadastroBasico dadosCadastroBasico { get; set; }
	}

}

