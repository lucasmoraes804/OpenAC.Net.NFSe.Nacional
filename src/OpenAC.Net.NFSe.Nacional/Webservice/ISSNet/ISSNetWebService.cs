using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using OpenAC.Net.Core.Logging;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.NFSe.Nacional.Common;
using OpenAC.Net.NFSe.Nacional.Common.Model;
using OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;
using OpenAC.Net.NFSe.Nacional.Common.Types;
using OpenAC.Net.NFSe.Nacional.Webservice.Nacional;

namespace OpenAC.Net.NFSe.Nacional.Webservice.ISSNet;

public class ISSNetWebService : NacionalWebservice
{
    public ISSNetWebService(ConfiguracaoNFSe configuracaoNFSe, NFSeServiceInfo serviceInfo)
        : base(configuracaoNFSe, serviceInfo) { }

    /// <summary>
    /// Gera NFS-e a partir de uma DPS.
    /// </summary>
    public async Task<GerarNfseResposta> GerarNfseAsync(Dps dps)
    {
        dps.Assinar(Configuracao);
        ValidarSchema(SchemaNFSe.DPS, dps.Xml, dps.Versao);

        var documento = dps.Informacoes.Prestador.CPF ?? dps.Informacoes.Prestador.CNPJ;

        GravarDpsEmDisco(dps.Xml, $"{dps.Informacoes.NumeroDps:000000}_dps.xml",
            documento, dps.Informacoes.DhEmissao.DateTime);

        var envio = new GerarNfseEnvio { Dps = dps };
        return await EnviarXmlAsync<GerarNfseResposta, GerarNfseEnvio>(envio, TipoUrl.GerarNfse,
            $"GerarNfse-{dps.Informacoes.NumeroDps:000000}", documento, dps.Versao);
    }

    /// <summary>
    /// Solicita cancelamento de NFS-e via pedido de registro de evento.
    /// </summary>
    public async Task<CancelarNfseResposta> CancelarNfseAsync(PedidoRegistroEvento pedido)
    {
        pedido.Assinar(Configuracao);
        ValidarSchema(SchemaNFSe.Evento, pedido.Xml, pedido.Versao);

        var documento = pedido.Informacoes.CPFAutor ?? pedido.Informacoes.CNPJAutor;

        GravarDpsEmDisco(pedido.Xml, $"{pedido.Informacoes.ChNFSe}{pedido.Informacoes.Evento}_evento.xml",
            documento, pedido.Informacoes.DhEvento.DateTime);

        var envio = new CancelarNfseEnvio { PedidoRegistroEvento = pedido };
        return await EnviarXmlAsync<CancelarNfseResposta, CancelarNfseEnvio>(envio, TipoUrl.CancelarNfse,
            $"CancelarNfse-{pedido.Informacoes.ChNFSe}", documento, pedido.Versao);
    }

    /// <summary>
    /// Envia lote de DPS para processamento assincrono.
    /// </summary>
    public async Task<EnviarLoteDpsResposta> RecepcionarLoteDpsAsync(LoteDpsISSNet lote)
    {
        AssinarLoteDps(lote);
        var envio = new EnviarLoteDpsEnvio { LoteDps = lote };
        return await EnviarXmlAsync<EnviarLoteDpsResposta, EnviarLoteDpsEnvio>(envio, TipoUrl.RecepcionarLoteDps,
            $"RecepcionarLoteDps-{lote.NumeroLote}", lote.Prestador.CNPJ ?? lote.Prestador.CPF, lote.Versao);
    }

    /// <summary>
    /// Envia lote de DPS para processamento sincrono.
    /// </summary>
    public async Task<EnviarLoteDpsSincronoResposta> RecepcionarLoteDpsSincronoAsync(LoteDpsISSNet lote)
    {
        AssinarLoteDps(lote);
        var envio = new EnviarLoteDpsSincronoEnvio { LoteDps = lote };
        return await EnviarXmlAsync<EnviarLoteDpsSincronoResposta, EnviarLoteDpsSincronoEnvio>(envio,
            TipoUrl.RecepcionarLoteDpsSincrono, $"RecepcionarLoteDpsSincrono-{lote.NumeroLote}",
            lote.Prestador.CNPJ ?? lote.Prestador.CPF, lote.Versao);
    }

    /// <summary>
    /// Consulta o processamento de um lote de DPS pelo protocolo.
    /// </summary>
    public Task<ConsultarLoteDpsResposta> ConsultarLoteDpsAsync(ConsultarLoteDpsEnvio envio)
    {
        return EnviarXmlAsync<ConsultarLoteDpsResposta, ConsultarLoteDpsEnvio>(envio, TipoUrl.ConsultarLoteDps,
            $"ConsultarLoteDps-{envio.Protocolo}", envio.Prestador.CNPJ ?? envio.Prestador.CPF, VersaoNFSe.Ve101);
    }

    /// <summary>
    /// Consulta NFS-e a partir da identificacao do DPS.
    /// </summary>
    public Task<ConsultarNfseDpsResposta> ConsultarNfseDpsAsync(ConsultarNfseDpsEnvio envio)
    {
        return EnviarXmlAsync<ConsultarNfseDpsResposta, ConsultarNfseDpsEnvio>(envio, TipoUrl.ConsultarNfseDps,
            $"ConsultarNfseDps-{envio.IdentificacaoDps.NumeroDps}", envio.Prestador.CNPJ ?? envio.Prestador.CPF,
            VersaoNFSe.Ve101);
    }

    /// <summary>
    /// Consulta NFS-e por faixa de numero.
    /// </summary>
    public Task<ConsultarNfseFaixaResposta> ConsultarNfsePorFaixaAsync(ConsultarNfseFaixaEnvio envio)
    {
        return EnviarXmlAsync<ConsultarNfseFaixaResposta, ConsultarNfseFaixaEnvio>(envio, TipoUrl.ConsultarNfsePorFaixa,
            $"ConsultarNfseFaixa-{envio.Faixa.NumeroInicial}-{envio.Faixa.NumeroFinal}",
            envio.Prestador.CNPJ ?? envio.Prestador.CPF, VersaoNFSe.Ve101);
    }

    /// <summary>
    /// Consulta NFS-e de servicos prestados por numero ou periodo.
    /// </summary>
    public Task<ConsultarNfseServicoPrestadoResposta> ConsultarNfseServicoPrestadoAsync(ConsultarNfseServicoPrestadoEnvio envio)
    {
        ValidarPeriodoConsulta(envio.NumeroNfse, envio.PeriodoEmissao, envio.PeriodoCompetencia);

        return EnviarXmlAsync<ConsultarNfseServicoPrestadoResposta, ConsultarNfseServicoPrestadoEnvio>(envio,
            TipoUrl.ConsultarNfseServicoPrestado, $"ConsultarNfseServicoPrestado-{envio.Pagina}",
            envio.Prestador.CNPJ ?? envio.Prestador.CPF, VersaoNFSe.Ve101);
    }

    /// <summary>
    /// Consulta NFS-e de servicos tomados ou intermediados.
    /// </summary>
    public Task<ConsultarNfseServicoTomadoResposta> ConsultarNfseServicoTomadoAsync(ConsultarNfseServicoTomadoEnvio envio)
    {
        ValidarPeriodoConsulta(envio.NumeroNfse, envio.PeriodoEmissao, envio.PeriodoCompetencia);
        if (envio.Tomador == null && envio.Intermediario == null)
            throw new InvalidOperationException("Tomador ou Intermediario deve ser informado.");

        return EnviarXmlAsync<ConsultarNfseServicoTomadoResposta, ConsultarNfseServicoTomadoEnvio>(envio,
            TipoUrl.ConsultarNfseServicoTomado, $"ConsultarNfseServicoTomado-{envio.Pagina}",
            envio.Consulente.CNPJ ?? envio.Consulente.CPF, VersaoNFSe.Ve101);
    }

    /// <summary>
    /// Consulta URLs de visualizacao/autenticidade da NFS-e.
    /// </summary>
    public Task<ConsultarUrlNfseResposta> ConsultarUrlNfseAsync(ConsultarUrlNfseEnvio envio)
    {
        ValidarPeriodoConsulta(envio.NumeroNfse, envio.PeriodoEmissao, envio.PeriodoCompetencia);

        return EnviarXmlAsync<ConsultarUrlNfseResposta, ConsultarUrlNfseEnvio>(envio, TipoUrl.ConsultarUrlNfse,
            $"ConsultarUrlNfse-{envio.Pagina}", envio.Prestador.CNPJ ?? envio.Prestador.CPF, VersaoNFSe.Ve101);
    }

    /// <summary>
    /// Consulta dados cadastrais do prestador.
    /// </summary>
    public Task<ConsultarDadosCadastraisResposta> ConsultarDadosCadastraisAsync(ConsultarDadosCadastraisEnvio envio)
    {
        return EnviarXmlAsync<ConsultarDadosCadastraisResposta, ConsultarDadosCadastraisEnvio>(envio,
            TipoUrl.ConsultarDadosCadastrais, $"ConsultarDadosCadastrais-{envio.Prestador.InscricaoMunicipal}",
            envio.Prestador.CNPJ ?? envio.Prestador.CPF, VersaoNFSe.Ve101);
    }

    /// <summary>
    /// Consulta DPS disponivel por prestador.
    /// </summary>
    public Task<ConsultarDpsDisponivelResposta> ConsultarDpsDisponivelAsync(ConsultarDpsDisponivelEnvio envio)
    {
        return EnviarXmlAsync<ConsultarDpsDisponivelResposta, ConsultarDpsDisponivelEnvio>(envio,
            TipoUrl.ConsultarDpsDisponivel, $"ConsultarDpsDisponivel-{envio.Pagina}",
            envio.Prestador.CNPJ ?? envio.Prestador.CPF, VersaoNFSe.Ve101);
    }

    /// <summary>
    /// Envia XML para validacao no endpoint ISSNet.
    /// </summary>
    public async Task<string> ValidarXmlAsync(string xml)
    {
        if (string.IsNullOrWhiteSpace(xml))
            throw new InvalidOperationException("O XML a validar deve ser informado.");

        return await EnviarXmlAsync(xml, TipoUrl.ValidarXml, "ValidarXml", null);
    }

    /// <summary>
    /// Serializa, valida e envia XML e desserializa a resposta.
    /// </summary>
    private async Task<TResponse> EnviarXmlAsync<TResponse, TRequest>(TRequest request, TipoUrl tipoUrl,
        string nomeArquivo, string? documento, VersaoNFSe versao)
        where TResponse : DFeDocument<TResponse>
        where TRequest : DFeDocument<TRequest>
    {
        var xmlEnvio = request.Xml;
        ValidarSchema(SchemaNFSe.ISSNet, xmlEnvio, versao);

        this.Log().Debug($"ISSNet: [{nomeArquivo}][Envio] - {xmlEnvio}");
        GravarArquivoEmDisco(xmlEnvio, $"{nomeArquivo}-env.xml", documento);

        var strResponse = await EnviarXmlAsync(xmlEnvio, tipoUrl, nomeArquivo, documento);
        return DFeDocument<TResponse>.Load(strResponse);
    }

    /// <summary>
    /// Envia o XML cru para o endpoint informado.
    /// </summary>
    private async Task<string> EnviarXmlAsync(string xmlEnvio, TipoUrl tipoUrl, string nomeArquivo, string? documento)
    {
        string? url = ServiceInfo[Configuracao.WebServices.Ambiente][tipoUrl];
        if (string.IsNullOrWhiteSpace(url))
            throw new InvalidOperationException("URL nao encontrada na configuracao do servico.");

        using var content = new StringContent(xmlEnvio, Encoding.UTF8, "application/xml");
        HttpResponseMessage httpResponse = await SendAsync(content, HttpMethod.Post, url);

        var strResponse = await httpResponse.Content.ReadAsStringAsync();
        this.Log().Debug($"ISSNet: [{nomeArquivo}][Resposta] - {strResponse}");
        GravarArquivoEmDisco(strResponse, $"{nomeArquivo}-resp.xml", documento);

        return strResponse;
    }

    /// <summary>
    /// Assina e valida cada DPS do lote.
    /// </summary>
    private void AssinarLoteDps(LoteDpsISSNet lote)
    {
        foreach (var dps in lote.Dps)
        {
            dps.Assinar(Configuracao);
            ValidarSchema(SchemaNFSe.DPS, dps.Xml, dps.Versao);
        }
    }

    /// <summary>
    /// Valida a regra de escolha entre numero e periodo na consulta.
    /// </summary>
    private static void ValidarPeriodoConsulta(string? numeroNfse, Periodo? periodoEmissao, Periodo? periodoCompetencia)
    {
        if (string.IsNullOrWhiteSpace(numeroNfse) && periodoEmissao == null && periodoCompetencia == null)
            throw new InvalidOperationException("NumeroNfse ou PeriodoEmissao ou PeriodoCompetencia deve ser informado.");
    }
}
