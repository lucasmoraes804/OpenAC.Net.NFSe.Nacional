using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

[DFeRoot("ConsultarNfseServicoPrestadoEnvio", Namespace = "http://www.sped.fazenda.gov.br/nfse")]
public sealed class ConsultarNfseServicoPrestadoEnvio : DFeDocument<ConsultarNfseServicoPrestadoEnvio>
{
    /// <summary>
    /// Identificacao do prestador.
    /// </summary>
    [DFeElement("Prestador", Ocorrencia = Ocorrencia.Obrigatoria)]
    public IdentificacaoPessoaEmpresa Prestador { get; set; } = new();

    /// <summary>
    /// Numero da NFS-e (alternativo aos periodos).
    /// </summary>
    [DFeElement(TipoCampo.StrNumber, "NumeroNfse", Min = 1, Max = 13, Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? NumeroNfse { get; set; }

    /// <summary>
    /// Periodo de emissao (DataInicial e DataFinal).
    /// </summary>
    [DFeElement("PeriodoEmissao", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public Periodo? PeriodoEmissao { get; set; }

    /// <summary>
    /// Periodo de competencia (DataInicial e DataFinal).
    /// </summary>
    [DFeElement("PeriodoCompetencia", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public Periodo? PeriodoCompetencia { get; set; }

    /// <summary>
    /// Identificacao do tomador (opcional).
    /// </summary>
    [DFeElement("Tomador", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public IdentificacaoPessoaEmpresa? Tomador { get; set; }

    /// <summary>
    /// Identificacao do intermediario (opcional).
    /// </summary>
    [DFeElement("Intermediario", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public IdentificacaoPessoaEmpresa? Intermediario { get; set; }

    /// <summary>
    /// Pagina da consulta (ate 50 notas).
    /// </summary>
    [DFeElement(TipoCampo.Int, "Pagina", Min = 1, Max = 999, Ocorrencia = Ocorrencia.Obrigatoria)]
    public int Pagina { get; set; } = 1;
}