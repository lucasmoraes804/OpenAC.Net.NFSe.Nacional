using System;
using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Serializer;
using OpenAC.Net.NFSe.Nacional.Common.Types;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

public sealed class InfEventoISSNet
{
    /// <summary>
    /// Identificador do evento (EVT + chave + tipo + sequencial).
    /// </summary>
    [DFeAttribute(TipoCampo.Str, "Id")]
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// Versao do aplicativo que gerou o evento.
    /// </summary>
    [DFeElement(TipoCampo.Str, "verAplic", Min = 1, Max = 20, Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? VersaoAplicacao { get; set; }

    /// <summary>
    /// Ambiente gerador do evento.
    /// </summary>
    [DFeElement(TipoCampo.Enum, "ambGer", Ocorrencia = Ocorrencia.Obrigatoria)]
    public AmbienteGerador AmbienteGerador { get; set; }

    /// <summary>
    /// Numero sequencial do evento para o mesmo tipo.
    /// </summary>
    [DFeElement(TipoCampo.StrNumber, "nSeqEvento", Min = 1, Max = 3, Ocorrencia = Ocorrencia.Obrigatoria)]
    public string NumeroSequencial { get; set; } = "1";

    /// <summary>
    /// Data/hora do processamento do evento.
    /// </summary>
    [DFeElement(TipoCampo.DatHorTz, "dhProc", Ocorrencia = Ocorrencia.Obrigatoria)]
    public DateTimeOffset DhProcessamento { get; set; }

    /// <summary>
    /// Numero sequencial do DFe gerado pelo ambiente emissor.
    /// </summary>
    [DFeElement(TipoCampo.StrNumber, "nDFe", Min = 1, Max = 13, Ocorrencia = Ocorrencia.Obrigatoria)]
    public string NumeroDFe { get; set; } = string.Empty;

    /// <summary>
    /// Pedido de registro do evento relacionado.
    /// </summary>
    [DFeElement("pedRegEvento", Ocorrencia = Ocorrencia.Obrigatoria)]
    public PedidoRegistroEvento PedidoRegistroEvento { get; set; } = new();
}
