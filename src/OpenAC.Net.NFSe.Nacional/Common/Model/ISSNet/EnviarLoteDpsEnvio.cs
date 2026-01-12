using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

[DFeRoot("EnviarLoteDpsEnvio", Namespace = "http://www.sped.fazenda.gov.br/nfse")]
public sealed class EnviarLoteDpsEnvio : DFeDocument<EnviarLoteDpsEnvio>
{
    /// <summary>
    /// Lote de DPS.
    /// </summary>
    [DFeElement("LoteDps", Ocorrencia = Ocorrencia.Obrigatoria)]
    public LoteDpsISSNet LoteDps { get; set; } = new();
}