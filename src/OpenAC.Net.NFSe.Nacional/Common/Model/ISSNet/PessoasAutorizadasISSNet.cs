using System.Collections.Generic;
using OpenAC.Net.DFe.Core.Attributes;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

public sealed class PessoasAutorizadasISSNet
{
    /// <summary>
    /// Lista de pessoas autorizadas.
    /// </summary>
    [DFeCollection("PessoasAutorizada", MinSize = 0)]
    [DFeItem(typeof(PessoaAutorizadaISSNet), "PessoasAutorizada")]
    public List<PessoaAutorizadaISSNet> Pessoas { get; set; } = new();
}