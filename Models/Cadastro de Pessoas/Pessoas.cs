using System;

namespace CadastroPessoas
{
	public class Pessoas
	{
		public Int64 OId { get; set; }
		public String nome { get; set; }
		public DateTime dataNascimento { get; set; }
		public DocumentosIdentidade documentoIdentidade { get; set; }
		public DadosCadastroBasico dadosBasicos { get; set; }
		public String naturalidade { get; set; }
		public char sexo { get; set; }
		public String nacionalidade { get; set; }
		public String estadoCivil { get; set; }
		public String profissão { get; set; }
		public DadosCadastroBasico dadosCadastroBasico { get; set; }
		public Clientes clientes { get; set; }
		public Dentistas dentistas { get; set; }
		public Secretarias secretarias { get; set; }
		public TecnicosEAuxiliares tecnicosEAuxiliares { get; set; }
	}

}

