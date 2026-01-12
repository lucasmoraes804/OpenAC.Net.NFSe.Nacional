using System.Collections.Generic;
using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Serializer;
using OpenAC.Net.NFSe.Nacional.Common.Types;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

public sealed class LoteDpsISSNet
{
    /// <summary>
    /// Identificador do lote (atributo Id).
    /// </summary>
    [DFeAttribute(TipoCampo.Str, "Id")]
    public string? Id { get; set; }

    /// <summary>
    /// Versao do layout do lote.
    /// </summary>
    [DFeAttribute(TipoCampo.Enum, "versao", Ocorrencia = Ocorrencia.Obrigatoria)]
    public VersaoNFSe Versao { get; set; } = VersaoNFSe.Ve101;

    /// <summary>
    /// Numero do lote.
    /// </summary>
    [DFeElement(TipoCampo.StrNumber, "NumeroLote", Min = 1, Max = 15, Ocorrencia = Ocorrencia.Obrigatoria)]
    public string NumeroLote { get; set; } = string.Empty;

    /// <summary>
    /// Identificacao do prestador do lote.
    /// </summary>
    [DFeElement("Prestador", Ocorrencia = Ocorrencia.Obrigatoria)]
    public IdentificacaoPessoaEmpresa Prestador { get; set; } = new();

    /// <summary>
    /// Quantidade de DPS no lote.
    /// </summary>
    [DFeElement(TipoCampo.Int, "QuantidadeDps", Min = 1, Max = 999, Ocorrencia = Ocorrencia.Obrigatoria)]
    public int QuantidadeDps { get; set; }

    /// <summary>
    /// Lista de DPS assinadas.
    /// </summary>
    [DFeCollection("ListaDps", MinSize = 1, MaxSize = 999)]
    [DFeItem(typeof(Dps), "DPS")]
    public List<Dps> Dps { get; set; } = new();
}
