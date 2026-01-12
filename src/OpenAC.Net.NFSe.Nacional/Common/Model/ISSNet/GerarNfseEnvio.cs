using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

[DFeRoot("GerarNfseEnvio", Namespace = "http://www.sped.fazenda.gov.br/nfse")]
public sealed class GerarNfseEnvio : DFeDocument<GerarNfseEnvio>
{
    /// <summary>
    /// DPS que sera convertida em NFS-e.
    /// </summary>
    [DFeElement("DPS", Ocorrencia = Ocorrencia.Obrigatoria)]
    public Dps Dps { get; set; } = new();
}