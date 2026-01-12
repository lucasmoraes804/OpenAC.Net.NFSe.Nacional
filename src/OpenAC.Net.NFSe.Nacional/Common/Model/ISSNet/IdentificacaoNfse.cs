using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Serializer;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

public sealed class IdentificacaoNfse
{
    /// <summary>
    /// Numero do DFSe.
    /// </summary>
    [DFeElement(TipoCampo.StrNumber, "nDFSe", Min = 1, Max = 13, Ocorrencia = Ocorrencia.Obrigatoria)]
    public string NumeroDfse { get; set; } = string.Empty;

    /// <summary>
    /// CNPJ do emitente.
    /// </summary>
    [DFeElement(TipoCampo.StrNumber, "CNPJ", Min = 14, Max = 14, Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? CNPJ { get; set; }

    /// <summary>
    /// CPF do emitente.
    /// </summary>
    [DFeElement(TipoCampo.StrNumber, "CPF", Min = 11, Max = 11, Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? CPF { get; set; }

    /// <summary>
    /// Inscricao municipal do emitente.
    /// </summary>
    [DFeElement(TipoCampo.StrNumber, "IM", Min = 1, Max = 15, Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? InscricaoMunicipal { get; set; }

    /// <summary>
    /// Codigo do municipio emissor (IBGE, 7 digitos).
    /// </summary>
    [DFeElement(TipoCampo.StrNumber, "cMunNFSeMun", Min = 7, Max = 7, Ocorrencia = Ocorrencia.Obrigatoria)]
    public string CodigoMunicipio { get; set; } = string.Empty;
}