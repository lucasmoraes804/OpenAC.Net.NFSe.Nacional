using System.Collections.Generic;
using OpenAC.Net.DFe.Core.Attributes;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

public sealed class ListaMensagemRetorno
{
    /// <summary>
    /// Lista de mensagens de retorno.
    /// </summary>
    [DFeCollection("MensagemRetorno", MinSize = 1)]
    [DFeItem(typeof(MensagemRetorno), "MensagemRetorno")]
    public List<MensagemRetorno> Mensagens { get; set; } = new();
}