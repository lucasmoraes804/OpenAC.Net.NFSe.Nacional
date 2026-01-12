using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Serializer;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

public sealed class IdentificacaoDps
{
    /// <summary>
    /// Numero do DPS.
    /// </summary>
    [DFeElement(TipoCampo.StrNumber, "NumDPS", Min = 1, Max = 15, Ocorrencia = Ocorrencia.Obrigatoria)]
    public string NumeroDps { get; set; } = string.Empty;

    /// <summary>
    /// Serie do DPS.
    /// </summary>
    [DFeElement(TipoCampo.Str, "SerieDPS", Min = 1, Max = 5, Ocorrencia = Ocorrencia.Obrigatoria)]
    public string SerieDps { get; set; } = string.Empty;
}