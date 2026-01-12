using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

[DFeRoot("ConsultarNfseFaixaEnvio", Namespace = "http://www.sped.fazenda.gov.br/nfse")]
public sealed class ConsultarNfseFaixaEnvio : DFeDocument<ConsultarNfseFaixaEnvio>
{
    /// <summary>
    /// Identificacao do prestador.
    /// </summary>
    [DFeElement("Prestador", Ocorrencia = Ocorrencia.Obrigatoria)]
    public IdentificacaoPessoaEmpresa Prestador { get; set; } = new();

    /// <summary>
    /// Faixa de numeros de NFS-e.
    /// </summary>
    [DFeElement("Faixa", Ocorrencia = Ocorrencia.Obrigatoria)]
    public FaixaNfse Faixa { get; set; } = new();

    /// <summary>
    /// Pagina da consulta (ate 50 notas).
    /// </summary>
    [DFeElement(TipoCampo.Int, "Pagina", Min = 1, Max = 999, Ocorrencia = Ocorrencia.Obrigatoria)]
    public int Pagina { get; set; } = 1;
}