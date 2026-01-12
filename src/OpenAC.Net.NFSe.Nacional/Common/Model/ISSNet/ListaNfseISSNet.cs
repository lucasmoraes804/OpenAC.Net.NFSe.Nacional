using System.Collections.Generic;
using OpenAC.Net.DFe.Core.Attributes;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

public sealed class ListaNfseISSNet
{
    /// <summary>
    /// Lista de composicoes de NFS-e (CompNfse).
    /// </summary>
    [DFeCollection("CompNfse", MinSize = 1, MaxSize = 50)]
    [DFeItem(typeof(CompNfseISSNet), "CompNfse")]
    public List<CompNfseISSNet> Nfses { get; set; } = new();

    /// <summary>
    /// Lista de mensagens de alerta, quando aplicavel.
    /// </summary>
    [DFeElement("ListaMensagemAlertaRetorno", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public ListaMensagemAlertaRetorno? Alertas { get; set; }
}