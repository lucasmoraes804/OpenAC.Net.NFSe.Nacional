using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

[DFeRoot("CancelarNfseResposta", Namespace = "http://www.sped.fazenda.gov.br/nfse")]
public sealed class CancelarNfseResposta : DFeDocument<CancelarNfseResposta>
{
    /// <summary>
    /// Evento retornado pela administracao tributaria.
    /// </summary>
    [DFeElement("Evento", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public EventoISSNet? Evento { get; set; }

    /// <summary>
    /// Mensagens de retorno, quando houver erro.
    /// </summary>
    [DFeElement("ListaMensagemRetorno", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public ListaMensagemRetorno? MensagensRetorno { get; set; }
}