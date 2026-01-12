using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;
using OpenAC.Net.NFSe.Nacional.Common.Types;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

public sealed class EventoISSNet
{
    /// <summary>
    /// Versao do layout do evento.
    /// </summary>
    [DFeAttribute(TipoCampo.Enum, "versao", Ocorrencia = Ocorrencia.Obrigatoria)]
    public VersaoNFSe Versao { get; set; } = VersaoNFSe.Ve101;

    /// <summary>
    /// Informacoes do evento.
    /// </summary>
    [DFeElement("infEvento", Ocorrencia = Ocorrencia.Obrigatoria)]
    public InfEventoISSNet Informacoes { get; set; } = new();

    /// <summary>
    /// Assinatura digital do evento (quando presente).
    /// </summary>
    [DFeElement("Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public DFeSignature? Signature { get; set; }
}