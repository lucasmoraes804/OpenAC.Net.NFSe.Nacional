using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

[DFeRoot("ConsultarLoteDpsResposta", Namespace = "http://www.sped.fazenda.gov.br/nfse")]
public sealed class ConsultarLoteDpsResposta : DFeDocument<ConsultarLoteDpsResposta>
{
    /// <summary>
    /// Situacao do lote (1 a 4).
    /// </summary>
    [DFeElement(TipoCampo.Int, "Situacao", Min = 1, Max = 4, Ocorrencia = Ocorrencia.Obrigatoria)]
    public int Situacao { get; set; }

    /// <summary>
    /// Lista de NFS-e retornadas.
    /// </summary>
    [DFeElement("ListaNfse", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public ListaNfseISSNet? ListaNfse { get; set; }

    /// <summary>
    /// Mensagens gerais de retorno.
    /// </summary>
    [DFeElement("ListaMensagemRetorno", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public ListaMensagemRetorno? MensagensRetorno { get; set; }

    /// <summary>
    /// Mensagens de retorno associadas ao lote/DPS.
    /// </summary>
    [DFeElement("ListaMensagemRetornoLote", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public ListaMensagemRetornoLote? MensagensRetornoLote { get; set; }
}