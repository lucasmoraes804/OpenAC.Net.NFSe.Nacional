using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

[DFeRoot("EnviarLoteDpsSincronoEnvio", Namespace = "http://www.sped.fazenda.gov.br/nfse")]
public sealed class EnviarLoteDpsSincronoEnvio : DFeDocument<EnviarLoteDpsSincronoEnvio>
{
    /// <summary>
    /// Lote de DPS processado de forma sincrona.
    /// </summary>
    [DFeElement("LoteDps", Ocorrencia = Ocorrencia.Obrigatoria)]
    public LoteDpsISSNet LoteDps { get; set; } = new();
}