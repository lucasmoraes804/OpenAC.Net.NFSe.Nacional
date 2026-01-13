using OpenAC.Net.DFe.Core.Common;
using OpenAC.Net.NFSe.Nacional.Common;
using OpenAC.Net.NFSe.Nacional.Common.Model;
using OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;
using OpenAC.Net.NFSe.Nacional.Common.Types;
using OpenAC.Net.NFSe.Nacional.Webservice;
using OpenAC.Net.NFSe.Nacional.Webservice.ISSNet;

namespace OpenAC.Net.NFSe.Nacional.Test;

[TestClass]
public class TestEmissaoISSNet
{
    [TestMethod]
    public async Task GerarNfseAsync()
    {
        var webService = CriarWebService(out var configuracao);
        var dps = CriarDpsBasico(configuracao);

        var resposta = await webService.GerarNfseAsync(dps);

        Assert.IsNotNull(resposta);
    }

    [TestMethod]
    public async Task CancelarNfseAsync()
    {
        var webService = CriarWebService(out var configuracao);
        var pedido = CriarPedidoCancelamento(configuracao);

        var resposta = await webService.CancelarNfseAsync(pedido);

        Assert.IsNotNull(resposta);
    }

    [TestMethod]
    public async Task RecepcionarLoteDpsAsync()
    {
        var webService = CriarWebService(out var configuracao);
        var lote = CriarLoteDps(configuracao);

        var resposta = await webService.RecepcionarLoteDpsAsync(lote);

        Assert.IsNotNull(resposta);
    }

    [TestMethod]
    public async Task RecepcionarLoteDpsSincronoAsync()
    {
        var webService = CriarWebService(out var configuracao);
        var lote = CriarLoteDps(configuracao);

        var resposta = await webService.RecepcionarLoteDpsSincronoAsync(lote);

        Assert.IsNotNull(resposta);
    }

    [TestMethod]
    public async Task ConsultarLoteDpsAsync()
    {
        var webService = CriarWebService(out _);
        var envio = new ConsultarLoteDpsEnvio
        {
            Prestador = CriarIdentificacaoPrestador(),
            Protocolo = DadosFicticiosIssNet.Protocolo
        };

        var resposta = await webService.ConsultarLoteDpsAsync(envio);

        Assert.IsNotNull(resposta);
    }

    [TestMethod]
    public async Task ConsultarNfseDpsAsync()
    {
        var webService = CriarWebService(out _);
        var envio = new ConsultarNfseDpsEnvio
        {
            Prestador = CriarIdentificacaoPrestador(),
            IdentificacaoDps = new IdentificacaoDps
            {
                NumeroDps = SetupOpenNFSeNacional.NumDPS,
                SerieDps = SetupOpenNFSeNacional.SerieDPS
            }
        };

        var resposta = await webService.ConsultarNfseDpsAsync(envio);

        Assert.IsNotNull(resposta);
    }

    [TestMethod]
    public async Task ConsultarNfsePorFaixaAsync()
    {
        var webService = CriarWebService(out _);
        var envio = new ConsultarNfseFaixaEnvio
        {
            Prestador = CriarIdentificacaoPrestador(),
            Faixa = new FaixaNfse
            {
                NumeroInicial = DadosFicticiosIssNet.NumeroNfseInicial,
                NumeroFinal = DadosFicticiosIssNet.NumeroNfseFinal
            },
            Pagina = DadosFicticiosIssNet.PaginaConsulta
        };

        var resposta = await webService.ConsultarNfsePorFaixaAsync(envio);

        Assert.IsNotNull(resposta);
    }

    [TestMethod]
    public async Task ConsultarNfseServicoPrestadoAsync()
    {
        var webService = CriarWebService(out _);
        var envio = new ConsultarNfseServicoPrestadoEnvio
        {
            Prestador = CriarIdentificacaoPrestador(),
            PeriodoEmissao = CriarPeriodoEmissao(),
            Pagina = DadosFicticiosIssNet.PaginaConsulta
        };

        var resposta = await webService.ConsultarNfseServicoPrestadoAsync(envio);

        Assert.IsNotNull(resposta);
    }

    [TestMethod]
    public async Task ConsultarNfseServicoTomadoAsync()
    {
        var webService = CriarWebService(out _);
        var envio = new ConsultarNfseServicoTomadoEnvio
        {
            Consulente = CriarIdentificacaoPrestador(),
            Tomador = CriarIdentificacaoTomador(),
            PeriodoEmissao = CriarPeriodoEmissao(),
            Pagina = DadosFicticiosIssNet.PaginaConsulta
        };

        var resposta = await webService.ConsultarNfseServicoTomadoAsync(envio);

        Assert.IsNotNull(resposta);
    }

    [TestMethod]
    public async Task ConsultarUrlNfseAsync()
    {
        var webService = CriarWebService(out _);
        var envio = new ConsultarUrlNfseEnvio
        {
            Prestador = CriarIdentificacaoPrestador(),
            PeriodoEmissao = CriarPeriodoEmissao(),
            Pagina = DadosFicticiosIssNet.PaginaConsulta
        };

        var resposta = await webService.ConsultarUrlNfseAsync(envio);

        Assert.IsNotNull(resposta);
    }

    [TestMethod]
    public async Task ConsultarDadosCadastraisAsync()
    {
        var webService = CriarWebService(out _);
        var envio = new ConsultarDadosCadastraisEnvio
        {
            Prestador = CriarIdentificacaoPrestador()
        };

        var resposta = await webService.ConsultarDadosCadastraisAsync(envio);

        Assert.IsNotNull(resposta);
    }

    [TestMethod]
    public async Task ConsultarDpsDisponivelAsync()
    {
        var webService = CriarWebService(out _);
        var envio = new ConsultarDpsDisponivelEnvio
        {
            Prestador = CriarIdentificacaoPrestador(),
            IdentificacaoDps = new IdentificacaoDps
            {
                NumeroDps = SetupOpenNFSeNacional.NumDPS,
                SerieDps = SetupOpenNFSeNacional.SerieDPS
            },
            Pagina = DadosFicticiosIssNet.PaginaConsulta
        };

        var resposta = await webService.ConsultarDpsDisponivelAsync(envio);

        Assert.IsNotNull(resposta);
    }

    [TestMethod]
    public async Task ValidarXmlAsync()
    {
        var webService = CriarWebService(out var configuracao);
        var dps = CriarDpsBasico(configuracao);
        dps.Assinar(configuracao);

        var resposta = await webService.ValidarXmlAsync(dps.Xml);

        Assert.IsNotNull(resposta);
    }

    private static ISSNetWebService CriarWebService(out ConfiguracaoNFSe configuracao)
    {
        var openNFSeNacional = new OpenNFSeNacional();
        SetupOpenNFSeNacional.ConfiguracaoModeloNovoCenario1(
            openNFSeNacional,
            DadosFicticiosIssNet.NumeroDps,
            DadosFicticiosIssNet.SerieDps,
            DadosFicticiosIssNet.NumeroEvento);

        var serviceInfo = ObterServiceInfoIssNet();
        configuracao = openNFSeNacional.Configuracoes;
        configuracao.Geral.Versao = VersaoNFSe.Ve101;
        configuracao.WebServices.Ambiente = DFeTipoAmbiente.Homologacao;
        configuracao.WebServices.CodigoMunicipio = serviceInfo.Codigo;
        configuracao.Arquivos.VersaoSchema = VersaoNFSe.Ve101;
        configuracao.Arquivos.PathSchemas = Path.Combine(AppContext.BaseDirectory, "Schemas", "ISSNet", "1.01");

        return new ISSNetWebService(configuracao, serviceInfo);
    }

    private static NFSeServiceInfo ObterServiceInfoIssNet()
    {
        return NFSeServiceManager.Instance.Services.Webservices
            .First(service => service.Provider == NFSeProvider.ISSNet);
    }

    private static Dps CriarDpsBasico(ConfiguracaoNFSe configuracao)
    {
        var tomador = SetupOpenNFSeNacional.ObterTomadorPadrao();

        var prestador = new PrestadorDps
        {
            InscricaoMunicipal = DadosFicticiosIssNet.InscricaoMunicipal
        };
        
        if(DadosFicticiosIssNet.DocumentoPrestador.Length == 11)
            prestador.CPF = DadosFicticiosIssNet.DocumentoPrestador;
        else
            prestador.CNPJ = DadosFicticiosIssNet.DocumentoPrestador;

        var servico = new ServicoNFSe
        {
            Localidade = new LocalidadeNFSe
            {
                CodMunicipioPrestacao = (tomador?.Endereco?.Municipio as MunicipioNacional)?.CodMunicipio
                    ?? SetupOpenNFSeNacional.CodMunIBGE
            },
            Informacoes = new InformacoesServico
            {
                CodTributacaoNacional = DadosFicticiosIssNet.CodigoTributacaoNacional,
                CodTributacaoMunicipio = DadosFicticiosIssNet.CodigoTributacaoMunicipio,
                Descricao = DadosFicticiosIssNet.DescricaoServico,
                CodNBS = DadosFicticiosIssNet.CodigoNBS
            }
        };

        var valores = new ValoresDps
        {
            ValoresServico = new ValoresServico
            {
                Valor = DadosFicticiosIssNet.ValorServico
            },
            Tributos = new TributosNFSe
            {
                Municipal = new TributoMunicipal
                {
                    ISSQN = TributoISSQN.OperacaoTributavel,
                    TipoRetencaoISSQN = TipoRetencaoISSQN.NaoRetido
                },
                Total = new TotalTributos
                {
                    PorcentagemTotal = new PorcentagemTotalTributos
                    {
                        TotalEstadual = 0,
                        TotalFederal = 0,
                        TotalMunicipal = 0
                    }
                }
            }
        };

        return new Dps
        {
            Versao = configuracao.Geral.Versao,
            Informacoes = new InfDps
            {
                TipoAmbiente = DFeTipoAmbiente.Homologacao,
                DhEmissao = DateTimeOffset.Now,
                LocalidadeEmitente = SetupOpenNFSeNacional.CodMunIBGE,
                Serie = SetupOpenNFSeNacional.SerieDPS,
                NumeroDps = SetupOpenNFSeNacional.NumDPS,
                Competencia = DateTime.Now.Date,
                TipoEmitente = EmitenteDps.Prestador,
                Prestador = prestador,
                Tomador = tomador,
                Servico = servico,
                Valores = valores
            }
        };
    }

    private static PedidoRegistroEvento CriarPedidoCancelamento(ConfiguracaoNFSe configuracao)
    {
        var cancelamento = new EventoCancelamento
        {
            CodMotivo = MotivoCancelamento.ErroEmissao,
            Motivo = DadosFicticiosIssNet.MotivoCancelamento
        };

        return new PedidoRegistroEvento
        {
            Versao = configuracao.Geral.Versao,
            Informacoes = new InfPedReg
            {
                Id = $"PRE{DadosFicticiosIssNet.ChaveNfse}{TipoEventoCod.Cancelamento}",
                ChNFSe = DadosFicticiosIssNet.ChaveNfse,
                CNPJAutor = SetupOpenNFSeNacional.TipoInscricaoFederal == 2
                    ? SetupOpenNFSeNacional.InscricaoFederal
                    : null,
                CPFAutor = SetupOpenNFSeNacional.TipoInscricaoFederal == 1
                    ? SetupOpenNFSeNacional.InscricaoFederal
                    : null,
                DhEvento = DateTimeOffset.Now,
                TipoAmbiente = DFeTipoAmbiente.Homologacao,
                Evento = cancelamento
            }
        };
    }

    private static LoteDpsISSNet CriarLoteDps(ConfiguracaoNFSe configuracao)
    {
        var dps = CriarDpsBasico(configuracao);

        return new LoteDpsISSNet
        {
            Id = $"Lote{DadosFicticiosIssNet.NumeroLote}",
            Versao = configuracao.Geral.Versao,
            NumeroLote = DadosFicticiosIssNet.NumeroLote,
            Prestador = CriarIdentificacaoPrestador(),
            QuantidadeDps = 1,
            Dps = { dps }
        };
    }

    private static IdentificacaoPessoaEmpresa CriarIdentificacaoPrestador()
    {
        return new IdentificacaoPessoaEmpresa
        {
            CNPJ = SetupOpenNFSeNacional.TipoInscricaoFederal == 2
                ? SetupOpenNFSeNacional.InscricaoFederal
                : null,
            CPF = SetupOpenNFSeNacional.TipoInscricaoFederal == 1
                ? SetupOpenNFSeNacional.InscricaoFederal
                : null,
            InscricaoMunicipal = SetupOpenNFSeNacional.InscricaoMunicipal
        };
    }

    private static IdentificacaoPessoaEmpresa CriarIdentificacaoTomador()
    {
        var tomador = SetupOpenNFSeNacional.ObterTomadorPadrao();

        return new IdentificacaoPessoaEmpresa
        {
            CNPJ = tomador?.CNPJ,
            CPF = tomador?.CPF
        };
    }

    private static Periodo CriarPeriodoEmissao()
    {
        return new Periodo
        {
            DataInicial = DadosFicticiosIssNet.DataInicial,
            DataFinal = DadosFicticiosIssNet.DataFinal
        };
    }

    private static class DadosFicticiosIssNet
    {
        public const string NumeroDps = "1";
        public const string SerieDps = "1";
        public const string NumeroEvento = "1";
        public const string NumeroLote = "1";
        public const string Protocolo = "PROTOCOLO-TESTE-001";
        public const string NumeroNfseInicial = "1";
        public const string NumeroNfseFinal = "10";
        public const int PaginaConsulta = 1;
        public const string ChaveNfse = "35253002242250933000187000000000000324057909658427";
        public const string MotivoCancelamento = "Dados invalidos";
        public const string DocumentoPrestador = "47013001000134"; //CPF ou CNPJ
        public const string EmailPrestador = "teste@exemplo.com";
        public const string CodigoTributacaoNacional = "010101";
        public const string CodigoTributacaoMunicipio = "001";
        public const string CodigoNBS = "101011100";
        public const string InscricaoMunicipal = "001";
        public const string DescricaoServico = "Servico de teste para ISSNet";
        public const decimal ValorServico = 100m;
        public static readonly DateTime DataInicial = new(2024, 01, 01);
        public static readonly DateTime DataFinal = new(2024, 01, 31);
    }
}
