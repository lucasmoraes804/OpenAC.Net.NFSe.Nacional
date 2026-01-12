using System.Collections.Generic;
using OpenAC.Net.DFe.Core.Attributes;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

public sealed class VigenciasISSNet
{
    /// <summary>
    /// Lista de vigencias.
    /// </summary>
    [DFeCollection("Vigencia", MinSize = 0)]
    [DFeItem(typeof(VigenciaISSNet), "Vigencia")]
    public List<VigenciaISSNet> Vigencias { get; set; } = new();
}