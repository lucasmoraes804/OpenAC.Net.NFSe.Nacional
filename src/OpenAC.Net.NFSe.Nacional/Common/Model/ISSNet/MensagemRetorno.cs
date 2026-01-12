using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Serializer;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

public sealed class MensagemRetorno
{
    /// <summary>
    /// Identificacao do DPS relacionado, quando aplicavel.
    /// </summary>
    [DFeElement("IdentificacaoDps", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public IdentificacaoDps? IdentificacaoDps { get; set; }

    /// <summary>
    /// Codigo da mensagem.
    /// </summary>
    [DFeElement(TipoCampo.Str, "Codigo", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? Codigo { get; set; }

    /// <summary>
    /// Texto principal da mensagem.
    /// </summary>
    [DFeElement(TipoCampo.Str, "Mensagem", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? Mensagem { get; set; }

    /// <summary>
    /// Texto de correcao sugerida, quando informado.
    /// </summary>
    [DFeElement(TipoCampo.Str, "Correcao", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? Correcao { get; set; }
}