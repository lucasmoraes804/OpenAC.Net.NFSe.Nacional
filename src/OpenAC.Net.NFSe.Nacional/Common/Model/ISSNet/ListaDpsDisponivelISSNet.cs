using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Serializer;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

public sealed class ListaDpsDisponivelISSNet
{
    /// <summary>
    /// Identificacao do prestador.
    /// </summary>
    [DFeElement("Prestador", Ocorrencia = Ocorrencia.Obrigatoria)]
    public IdentificacaoPessoaEmpresa Prestador { get; set; } = new();

    /// <summary>
    /// Dados do DPS disponivel.
    /// </summary>
    [DFeElement("DpsDisponivel", Ocorrencia = Ocorrencia.Obrigatoria)]
    public IdentificacaoDps DpsDisponivel { get; set; } = new();

    /// <summary>
    /// Pagina da consulta.
    /// </summary>
    [DFeElement(TipoCampo.Int, "Pagina", Min = 1, Max = 999, Ocorrencia = Ocorrencia.Obrigatoria)]
    public int Pagina { get; set; } = 1;
}