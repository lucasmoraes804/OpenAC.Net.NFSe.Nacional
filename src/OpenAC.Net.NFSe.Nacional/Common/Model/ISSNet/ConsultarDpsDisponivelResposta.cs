using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

[DFeRoot("ConsultarDpsDisponivelResposta", Namespace = "http://www.sped.fazenda.gov.br/nfse")]
public sealed class ConsultarDpsDisponivelResposta : DFeDocument<ConsultarDpsDisponivelResposta>
{
    /// <summary>
    /// Lista de DPS disponiveis.
    /// </summary>
    [DFeElement("ListaDpsDisponivel", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public ListaDpsDisponivelISSNet? ListaDpsDisponivel { get; set; }

    /// <summary>
    /// Mensagens de retorno, quando houver erro.
    /// </summary>
    [DFeElement("ListaMensagemRetorno", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public ListaMensagemRetorno? MensagensRetorno { get; set; }
}