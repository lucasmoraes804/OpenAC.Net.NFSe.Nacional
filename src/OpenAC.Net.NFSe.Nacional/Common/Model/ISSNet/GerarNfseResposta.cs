using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

[DFeRoot("GerarNfseResposta", Namespace = "http://www.sped.fazenda.gov.br/nfse")]
public sealed class GerarNfseResposta : DFeDocument<GerarNfseResposta>
{
    /// <summary>
    /// Lista de NFS-e retornadas (CompNfse).
    /// </summary>
    [DFeElement("ListaNfse", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public ListaNfseISSNet? ListaNfse { get; set; }

    /// <summary>
    /// Mensagens de retorno, quando houver erro.
    /// </summary>
    [DFeElement("ListaMensagemRetorno", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public ListaMensagemRetorno? MensagensRetorno { get; set; }
}