using System;
using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

[DFeRoot("EnviarLoteDpsResposta", Namespace = "http://www.sped.fazenda.gov.br/nfse")]
public sealed class EnviarLoteDpsResposta : DFeDocument<EnviarLoteDpsResposta>
{
    /// <summary>
    /// Numero do lote recebido.
    /// </summary>
    [DFeElement(TipoCampo.StrNumber, "NumeroLote", Min = 1, Max = 15, Ocorrencia = Ocorrencia.Obrigatoria)]
    public string NumeroLote { get; set; } = string.Empty;

    /// <summary>
    /// Data e hora do recebimento do lote.
    /// </summary>
    [DFeElement(TipoCampo.DatHorTz, "DataRecebimento", Ocorrencia = Ocorrencia.Obrigatoria)]
    public DateTimeOffset DataRecebimento { get; set; }

    /// <summary>
    /// Protocolo do lote recebido.
    /// </summary>
    [DFeElement(TipoCampo.Str, "Protocolo", Min = 1, Max = 50, Ocorrencia = Ocorrencia.Obrigatoria)]
    public string Protocolo { get; set; } = string.Empty;

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