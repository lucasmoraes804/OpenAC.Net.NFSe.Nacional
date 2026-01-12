namespace OpenAC.Net.NFSe.Nacional.Common.Types;

/// <summary>
/// Tipos de URL utilizadas pelos webservices da NFSe Nacional.
/// </summary>
public enum TipoUrl
{
    /// <summary>Enviar lote RPS ou NFSe.</summary>
    Enviar,

    /// <summary>Enviar evento relacionado a uma NFSe (ex.: cancelamento).</summary>
    EnviarEvento,

    /// <summary>Consultar por NSU (Número Sequencial Único).</summary>
    ConsultarNsu,

    /// <summary>Consultar NFSe por chave.</summary>
    ConsultarChave,

    /// <summary>Download do DANFSe (Documento Auxiliar da NFSe).</summary>
    DownloadDanfse,

    /// <summary>Consultar NFSe por chave do DPS (Documento de Prestação de Serviços).</summary>
    ConsultarChaveDps,

    /// <summary>Verificar existência do DPS.</summary>
    ConsultaExisteDps,

    /// <summary>Cancelar NFS-e.</summary>
    CancelarNfse,

    /// <summary>Consultar lote de DPS.</summary>
    ConsultarLoteDps,

    /// <summary>Consultar NFS-e de serviÇos prestados.</summary>
    ConsultarNfseServicoPrestado,

    /// <summary>Consultar NFS-e de serviÇos tomados.</summary>
    ConsultarNfseServicoTomado,

    /// <summary>Consultar NFS-e por faixa.</summary>
    ConsultarNfsePorFaixa,

    /// <summary>Consultar NFS-e por DPS.</summary>
    ConsultarNfseDps,

    /// <summary>Recepcionar lote de DPS.</summary>
    RecepcionarLoteDps,

    /// <summary>Gerar NFS-e.</summary>
    GerarNfse,

    /// <summary>Recepcionar lote de DPS sincrono.</summary>
    RecepcionarLoteDpsSincrono,

    /// <summary>Consultar URL da NFS-e.</summary>
    ConsultarUrlNfse,

    /// <summary>Consultar dados cadastrais.</summary>
    ConsultarDadosCadastrais,

    /// <summary>Consultar DPS disponivel.</summary>
    ConsultarDpsDisponivel,

    /// <summary>Validar XML.</summary>
    ValidarXml
}
