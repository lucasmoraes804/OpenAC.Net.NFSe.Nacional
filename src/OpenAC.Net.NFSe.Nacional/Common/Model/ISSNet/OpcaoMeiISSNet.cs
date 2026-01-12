using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Serializer;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

public sealed class OpcaoMeiISSNet
{
    /// <summary>
    /// Indicador de optante pelo MEI.
    /// </summary>
    [DFeElement(TipoCampo.Str, "OptanteMei", Ocorrencia = Ocorrencia.Obrigatoria)]
    public string OptanteMei { get; set; } = string.Empty;

    /// <summary>
    /// Vigencias da opcao.
    /// </summary>
    [DFeElement("Vigencias", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public VigenciasISSNet? Vigencias { get; set; }
}