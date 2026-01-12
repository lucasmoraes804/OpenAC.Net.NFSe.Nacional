using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

[DFeRoot("ConsultarNfseDpsResposta", Namespace = "http://www.sped.fazenda.gov.br/nfse")]
public sealed class ConsultarNfseDpsResposta : DFeDocument<ConsultarNfseDpsResposta>
{
    /// <summary>
    /// NFS-e retornada na consulta por DPS.
    /// </summary>
    [DFeElement("CompNfse", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public CompNfseISSNet? CompNfse { get; set; }

    /// <summary>
    /// Mensagens de retorno, quando houver erro.
    /// </summary>
    [DFeElement("ListaMensagemRetorno", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public ListaMensagemRetorno? MensagensRetorno { get; set; }
}