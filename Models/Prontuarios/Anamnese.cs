using System;

public class Anamnese
{
	public Int64 OId { get; set; }
	public Historico historico { get; set; }
	public String queixaPrincipal { get; set; }
	public Boolean dorDentesGengiva { get; set; }
	public Boolean sangramentoGengiva { get; set; }
	public Boolean gostoRuimBoca { get; set; }
	public Int16 vezesEscovacao { get; set; }
	public Boolean usaFioDental { get; set; }
	public Boolean dorMaxilar { get; set; }
	public Boolean estalosMaxilar { get; set; }
	public Boolean dorOuvido { get; set; }
	public Boolean estalosOuvido { get; set; }
	public Boolean rangeDentes { get; set; }
	public Boolean feridaBolhasFaceLabios { get; set; }
	public Historico historico { get; set; }
	public AnamneseDirecionada anamneseDirecionada { get; set; }
}

