using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Serializer;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

public sealed class IdentificacaoPessoaEmpresa
{
    /// <summary>
    /// CNPJ do prestador/tomador/intermediario (14 digitos).
    /// </summary>
    [DFeElement(TipoCampo.StrNumber, "CNPJ", Min = 14, Max = 14, Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? CNPJ { get; set; }

    /// <summary>
    /// CPF do prestador/tomador/intermediario (11 digitos).
    /// </summary>
    [DFeElement(TipoCampo.StrNumber, "CPF", Min = 11, Max = 11, Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? CPF { get; set; }

    /// <summary>
    /// Inscricao municipal, quando aplicavel.
    /// </summary>
    [DFeElement(TipoCampo.StrNumber, "IM", Min = 1, Max = 15, Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? InscricaoMunicipal { get; set; }
}
