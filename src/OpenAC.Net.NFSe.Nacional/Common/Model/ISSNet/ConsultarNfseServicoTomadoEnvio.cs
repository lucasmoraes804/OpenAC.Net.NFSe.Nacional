using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

[DFeRoot("ConsultarNfseServicoTomadoEnvio", Namespace = "http://www.sped.fazenda.gov.br/nfse")]
public sealed class ConsultarNfseServicoTomadoEnvio : DFeDocument<ConsultarNfseServicoTomadoEnvio>
{
    /// <summary>
    /// Identificacao do consulente.
    /// </summary>
    [DFeElement("Consulente", Ocorrencia = Ocorrencia.Obrigatoria)]
    public IdentificacaoPessoaEmpresa Consulente { get; set; } = new();

    /// <summary>
    /// Numero da NFS-e (alternativo aos periodos).
    /// </summary>
    [DFeElement(TipoCampo.StrNumber, "NumeroNfse", Min = 1, Max = 13, Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? NumeroNfse { get; set; }

    /// <summary>
    /// Periodo de emissao.
    /// </summary>
    [DFeElement("PeriodoEmissao", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public Periodo? PeriodoEmissao { get; set; }

    /// <summary>
    /// Periodo de competencia.
    /// </summary>
    [DFeElement("PeriodoCompetencia", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public Periodo? PeriodoCompetencia { get; set; }

    /// <summary>
    /// Identificacao do tomador (obrigatorio se intermediario nao informado).
    /// </summary>
    [DFeElement("Tomador", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public IdentificacaoPessoaEmpresa? Tomador { get; set; }

    /// <summary>
    /// Identificacao do intermediario (obrigatorio se tomador nao informado).
    /// </summary>
    [DFeElement("Intermediario", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public IdentificacaoPessoaEmpresa? Intermediario { get; set; }

    /// <summary>
    /// Pagina da consulta (ate 50 notas).
    /// </summary>
    [DFeElement(TipoCampo.Int, "Pagina", Min = 1, Max = 999, Ocorrencia = Ocorrencia.Obrigatoria)]
    public int Pagina { get; set; } = 1;
}