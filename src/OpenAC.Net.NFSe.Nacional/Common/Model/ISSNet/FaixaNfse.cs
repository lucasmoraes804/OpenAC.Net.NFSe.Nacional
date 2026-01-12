using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Serializer;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

public sealed class FaixaNfse
{
    /// <summary>
    /// Numero inicial da faixa de NFS-e.
    /// </summary>
    [DFeElement(TipoCampo.StrNumber, "NumeroNfseInicial", Min = 1, Max = 13, Ocorrencia = Ocorrencia.Obrigatoria)]
    public string NumeroInicial { get; set; } = string.Empty;

    /// <summary>
    /// Numero final da faixa de NFS-e.
    /// </summary>
    [DFeElement(TipoCampo.StrNumber, "NumeroNfseFinal", Min = 1, Max = 13, Ocorrencia = Ocorrencia.Obrigatoria)]
    public string NumeroFinal { get; set; } = string.Empty;
}