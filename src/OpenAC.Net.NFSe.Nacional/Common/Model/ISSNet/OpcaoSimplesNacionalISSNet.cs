using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Serializer;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

public sealed class OpcaoSimplesNacionalISSNet
{
    /// <summary>
    /// Indicador de optante pelo Simples Nacional.
    /// </summary>
    [DFeElement(TipoCampo.Str, "OptanteSimplesNacional", Ocorrencia = Ocorrencia.Obrigatoria)]
    public string OptanteSimplesNacional { get; set; } = string.Empty;

    /// <summary>
    /// Vigencias da opcao.
    /// </summary>
    [DFeElement("Vigencias", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public VigenciasISSNet? Vigencias { get; set; }
}