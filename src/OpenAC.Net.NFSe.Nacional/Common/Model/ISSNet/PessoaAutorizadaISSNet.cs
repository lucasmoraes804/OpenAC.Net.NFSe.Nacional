using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Serializer;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

public sealed class PessoaAutorizadaISSNet
{
    /// <summary>
    /// CNPJ autorizado.
    /// </summary>
    [DFeElement(TipoCampo.StrNumber, "CNPJ", Min = 14, Max = 14, Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? CNPJ { get; set; }

    /// <summary>
    /// CPF autorizado.
    /// </summary>
    [DFeElement(TipoCampo.StrNumber, "CPF", Min = 11, Max = 11, Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? CPF { get; set; }

    /// <summary>
    /// Razao social autorizada.
    /// </summary>
    [DFeElement(TipoCampo.Str, "RazaoSocial", Min = 1, Max = 300, Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? RazaoSocial { get; set; }
}