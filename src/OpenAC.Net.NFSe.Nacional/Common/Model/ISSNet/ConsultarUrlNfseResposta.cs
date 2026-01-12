using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

[DFeRoot("ConsultarUrlNfseResposta", Namespace = "http://www.sped.fazenda.gov.br/nfse")]
public sealed class ConsultarUrlNfseResposta : DFeDocument<ConsultarUrlNfseResposta>
{
    /// <summary>
    /// Lista de links retornados.
    /// </summary>
    [DFeElement("ListaLinks", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public ListaLinksISSNet? ListaLinks { get; set; }

    /// <summary>
    /// Mensagens de retorno, quando houver erro.
    /// </summary>
    [DFeElement("ListaMensagemRetorno", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public ListaMensagemRetorno? MensagensRetorno { get; set; }
}