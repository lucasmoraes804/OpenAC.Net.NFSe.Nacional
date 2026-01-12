using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

[DFeRoot("ConsultarNfseDpsEnvio", Namespace = "http://www.sped.fazenda.gov.br/nfse")]
public sealed class ConsultarNfseDpsEnvio : DFeDocument<ConsultarNfseDpsEnvio>
{
    /// <summary>
    /// Identificacao do DPS consultado.
    /// </summary>
    [DFeElement("IdentificacaoDps", Ocorrencia = Ocorrencia.Obrigatoria)]
    public IdentificacaoDps IdentificacaoDps { get; set; } = new();

    /// <summary>
    /// Identificacao do prestador.
    /// </summary>
    [DFeElement("Prestador", Ocorrencia = Ocorrencia.Obrigatoria)]
    public IdentificacaoPessoaEmpresa Prestador { get; set; } = new();
}