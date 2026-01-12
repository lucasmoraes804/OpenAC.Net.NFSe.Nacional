using System.Collections.Generic;
using OpenAC.Net.DFe.Core.Attributes;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

public sealed class ListaEventoISSNet
{
    /// <summary>
    /// Lista de eventos associados a uma NFS-e.
    /// </summary>
    [DFeCollection("Evento", MinSize = 1, MaxSize = 10)]
    [DFeItem(typeof(EventoISSNet), "Evento")]
    public List<EventoISSNet> Eventos { get; set; } = new();
}