using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

[DFeRoot("CancelarNfseEnvio", Namespace = "http://www.sped.fazenda.gov.br/nfse")]
public sealed class CancelarNfseEnvio : DFeDocument<CancelarNfseEnvio>
{
    /// <summary>
    /// Pedido de registro do evento de cancelamento.
    /// </summary>
    [DFeElement("pedRegEvento", Ocorrencia = Ocorrencia.Obrigatoria)]
    public PedidoRegistroEvento PedidoRegistroEvento { get; set; } = new();
}