using System.Collections.Generic;
using OpenAC.Net.DFe.Core.Attributes;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

public sealed class TributacoesPermitidasISSNet
{
    /// <summary>
    /// Lista de tributacoes ISSQN permitidas.
    /// </summary>
    [DFeCollection("tribISSQN", MinSize = 0)]
    [DFeItem(typeof(string), "tribISSQN")]
    public List<string> Tributacoes { get; set; } = new();
}