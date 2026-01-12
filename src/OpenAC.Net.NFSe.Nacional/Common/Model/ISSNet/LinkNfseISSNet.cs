using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Serializer;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

public sealed class LinkNfseISSNet
{
    /// <summary>
    /// Identificacao da NFS-e.
    /// </summary>
    [DFeElement("IdentificacaoNfse", Ocorrencia = Ocorrencia.Obrigatoria)]
    public IdentificacaoNfse IdentificacaoNfse { get; set; } = new();

    /// <summary>
    /// Identificacao do DPS relacionado.
    /// </summary>
    [DFeElement("IdentificacaoDps", Ocorrencia = Ocorrencia.Obrigatoria)]
    public IdentificacaoDps IdentificacaoDps { get; set; } = new();

    /// <summary>
    /// URL para visualizacao da NFS-e.
    /// </summary>
    [DFeElement(TipoCampo.Str, "UrlVisualizacaoNfse", Min = 1, Max = 500, Ocorrencia = Ocorrencia.Obrigatoria)]
    public string UrlVisualizacaoNfse { get; set; } = string.Empty;

    /// <summary>
    /// URL para verificacao de autenticidade.
    /// </summary>
    [DFeElement(TipoCampo.Str, "UrlVerificaAutenticidade", Min = 1, Max = 500, Ocorrencia = Ocorrencia.Obrigatoria)]
    public string UrlVerificaAutenticidade { get; set; } = string.Empty;
}