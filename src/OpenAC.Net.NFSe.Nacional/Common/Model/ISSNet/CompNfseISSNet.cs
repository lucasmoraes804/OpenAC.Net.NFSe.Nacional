using OpenAC.Net.DFe.Core.Attributes;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

public sealed class CompNfseISSNet
{
    /// <summary>
    /// NFS-e completa.
    /// </summary>
    [DFeElement("Nfse", Ocorrencia = Ocorrencia.Obrigatoria)]
    public NotaFiscalServico Nfse { get; set; } = new();

    /// <summary>
    /// Lista de eventos vinculados.
    /// </summary>
    [DFeElement("ListaEvento", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public ListaEventoISSNet? ListaEvento { get; set; }
}