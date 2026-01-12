using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

[DFeRoot("ConsultarDpsDisponivelEnvio", Namespace = "http://www.sped.fazenda.gov.br/nfse")]
public sealed class ConsultarDpsDisponivelEnvio : DFeDocument<ConsultarDpsDisponivelEnvio>
{
    /// <summary>
    /// Identificacao do prestador consultado.
    /// </summary>
    [DFeElement("Prestador", Ocorrencia = Ocorrencia.Obrigatoria)]
    public IdentificacaoPessoaEmpresa Prestador { get; set; } = new();

    /// <summary>
    /// Identificacao opcional de um DPS especifico.
    /// </summary>
    [DFeElement("IdentificacaoDps", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public IdentificacaoDps? IdentificacaoDps { get; set; }

    /// <summary>
    /// Pagina da consulta (ate 50 notas).
    /// </summary>
    [DFeElement(TipoCampo.Int, "Pagina", Min = 1, Max = 999, Ocorrencia = Ocorrencia.Obrigatoria)]
    public int Pagina { get; set; } = 1;
}