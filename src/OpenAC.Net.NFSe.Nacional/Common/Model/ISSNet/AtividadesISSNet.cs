using System.Collections.Generic;
using OpenAC.Net.DFe.Core.Attributes;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

public sealed class AtividadesISSNet
{
    /// <summary>
    /// Lista de atividades do cadastro.
    /// </summary>
    [DFeCollection("Atividade", MinSize = 0)]
    [DFeItem(typeof(AtividadeISSNet), "Atividade")]
    public List<AtividadeISSNet> Atividades { get; set; } = new();
}