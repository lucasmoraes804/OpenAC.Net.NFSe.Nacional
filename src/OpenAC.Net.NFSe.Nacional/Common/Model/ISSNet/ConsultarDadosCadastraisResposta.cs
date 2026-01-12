using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

[DFeRoot("ConsultarDadosCadastraisResposta", Namespace = "http://www.sped.fazenda.gov.br/nfse")]
public sealed class ConsultarDadosCadastraisResposta : DFeDocument<ConsultarDadosCadastraisResposta>
{
    /// <summary>
    /// Dados cadastrais do prestador.
    /// </summary>
    [DFeElement("Cadastro", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public CadastroISSNet? Cadastro { get; set; }

    /// <summary>
    /// Mensagens de retorno, quando houver erro.
    /// </summary>
    [DFeElement("ListaMensagemRetorno", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public ListaMensagemRetorno? MensagensRetorno { get; set; }
}