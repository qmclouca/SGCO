using System;

namespace CadastroPessoas
{
	public class DocumentosIdentidade
	{
		public Int64 OId {get; set; }
		public String cpf {get; set; }
		public String rg {get; set; }
		public String orgaoExpedidorRG {get; set; }
		public DadosCadastroBasico dadosCadastroBasico {get; set; }
	}
}

