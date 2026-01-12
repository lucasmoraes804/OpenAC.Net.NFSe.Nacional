using System.Collections.Generic;
using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Serializer;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

public sealed class ListaLinksISSNet
{
    /// <summary>
    /// Lista de links de NFS-e.
    /// </summary>
    [DFeCollection("Links", MinSize = 1, MaxSize = 50)]
    [DFeItem(typeof(LinkNfseISSNet), "Links")]
    public List<LinkNfseISSNet> Links { get; set; } = new();

    /// <summary>
    /// Pagina da consulta.
    /// </summary>
    [DFeElement(TipoCampo.Int, "Pagina", Min = 1, Max = 999, Ocorrencia = Ocorrencia.Obrigatoria)]
    public int Pagina { get; set; } = 1;
}