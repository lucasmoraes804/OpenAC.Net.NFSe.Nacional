using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

[DFeRoot("ConsultarNfseServicoTomadoResposta", Namespace = "http://www.sped.fazenda.gov.br/nfse")]
public sealed class ConsultarNfseServicoTomadoResposta : DFeDocument<ConsultarNfseServicoTomadoResposta>
{
    /// <summary>
    /// Lista de NFS-e paginada.
    /// </summary>
    [DFeElement("ListaNfse", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public ListaNfsePaginadaISSNet? ListaNfse { get; set; }

    /// <summary>
    /// Mensagens de retorno, quando houver erro.
    /// </summary>
    [DFeElement("ListaMensagemRetorno", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public ListaMensagemRetorno? MensagensRetorno { get; set; }
}