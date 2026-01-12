using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Serializer;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

public sealed class AtividadeISSNet
{
    /// <summary>
    /// Codigo de tributacao municipal.
    /// </summary>
    [DFeElement(TipoCampo.Str, "cTribMun", Min = 1, Max = 20, Ocorrencia = Ocorrencia.Obrigatoria)]
    public string CodigoTributacaoMunicipal { get; set; } = string.Empty;

    /// <summary>
    /// Descricao da tributacao municipal.
    /// </summary>
    [DFeElement(TipoCampo.Str, "xTribMun", Min = 1, Max = 200, Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? DescricaoTributacaoMunicipal { get; set; }

    /// <summary>
    /// Aliquota vinculada a atividade.
    /// </summary>
    [DFeElement(TipoCampo.De2, "pAliq", Min = 1, Max = 5, Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public decimal? Aliquota { get; set; }

    /// <summary>
    /// Vigencias da atividade.
    /// </summary>
    [DFeElement("Vigencias", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public VigenciasISSNet? Vigencias { get; set; }
}