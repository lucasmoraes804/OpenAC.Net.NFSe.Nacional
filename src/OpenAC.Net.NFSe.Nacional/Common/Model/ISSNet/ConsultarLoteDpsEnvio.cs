using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

[DFeRoot("ConsultarLoteDpsEnvio", Namespace = "http://www.sped.fazenda.gov.br/nfse")]
public sealed class ConsultarLoteDpsEnvio : DFeDocument<ConsultarLoteDpsEnvio>
{
    /// <summary>
    /// Identificacao do prestador do lote.
    /// </summary>
    [DFeElement("Prestador", Ocorrencia = Ocorrencia.Obrigatoria)]
    public IdentificacaoPessoaEmpresa Prestador { get; set; } = new();

    /// <summary>
    /// Protocolo informado no envio do lote.
    /// </summary>
    [DFeElement(TipoCampo.Str, "Protocolo", Min = 1, Max = 50, Ocorrencia = Ocorrencia.Obrigatoria)]
    public string Protocolo { get; set; } = string.Empty;
}