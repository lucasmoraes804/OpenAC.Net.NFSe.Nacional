using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

[DFeRoot("ConsultarDadosCadastraisEnvio", Namespace = "http://www.sped.fazenda.gov.br/nfse")]
public sealed class ConsultarDadosCadastraisEnvio : DFeDocument<ConsultarDadosCadastraisEnvio>
{
    /// <summary>
    /// Identificacao do prestador consultado.
    /// </summary>
    [DFeElement("Prestador", Ocorrencia = Ocorrencia.Obrigatoria)]
    public IdentificacaoPessoaEmpresa Prestador { get; set; } = new();
}