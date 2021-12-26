using System;

namespace CadastroPessoas
{
	public class DadosCadastroBasico
	{
		public Int64 OId { get; set; }
		public Enderecos endereco1 { get; set; }
		public Enderecos endereco2 { get; set; }
		public Contatos Contatos1 { get; set; }
		public Contatos Contatos2 { get; set; }
		public Contatos contatos { get; set; }
		public Enderecos enderecos { get; set; }
		public DocumentosIdentidade documentosIdentidade { get; set; }
		public Pessoas pessoas { get; set; }
		public Convenio convenio { get; set; }
	}

}

