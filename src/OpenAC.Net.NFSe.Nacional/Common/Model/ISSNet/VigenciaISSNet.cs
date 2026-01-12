using System;
using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Serializer;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

public sealed class VigenciaISSNet
{
    /// <summary>
    /// Data inicial de vigencia.
    /// </summary>
    [DFeElement(TipoCampo.Dat, "DataInicial", Ocorrencia = Ocorrencia.Obrigatoria)]
    public DateTime DataInicial { get; set; }

    /// <summary>
    /// Data final de vigencia.
    /// </summary>
    [DFeElement(TipoCampo.Dat, "DataFinal", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public DateTime? DataFinal { get; set; }
}