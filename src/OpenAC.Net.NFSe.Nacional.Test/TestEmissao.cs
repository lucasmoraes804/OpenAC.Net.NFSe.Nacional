using OpenAC.Net.Core.Extensions;
using OpenAC.Net.NFSe.Nacional.Common;

namespace OpenAC.Net.NFSe.Nacional.Test
{
    [TestClass]
    public class TestEmissao
    {
        [TestMethod]
        public async Task TestarEmissaoNFSe()
        {
            var openNFSeNacional = new OpenNFSeNacional();
            SetupOpenNFSeNacional.Configuracao(openNFSeNacional);

            var prest = new PrestadorDps()
            {
                CNPJ = SetupOpenNFSeNacional.InscricaoFederal,
                Email = "teste@teste.com",
                Regime = new RegimeTributario()
                {
                    OptanteSimplesNacional = OptanteSimplesNacional.OptanteMEI,
                    RegimeEspecial = RegimeEspecial.Nenhum
                }
            };

            var toma = new InfoPessoaNFSe()
            {
                CNPJ = "52309133000148",
                Nome = "Lecom Automação de Processos",
                Endereco = new EnderecoNFSe
                {
                    Bairro = "Centro",
                    Logradouro = "Rua Conde do Pinhal",
                    Municipio = new MunicipioNacional
                    {
                        CEP = "17201040",
                        CodMunicipio = "3525300"
                    },
                    Numero = "375"
                }
            };

            var serv = new ServicoNFSe() 
            {
                Localidade = new LocalidadeNFSe()
                {
                    CodMunicipioPrestacao = "3525300"
                },
                Informacoes = new InformacoesServico
                {
                    CodTributacaoNacional = "080201",
                    Descricao = "Referente ao serviço prestado"
                }
            };

            var valores = new ValoresDps() 
            {
                ValoresServico = new ValoresServico
                {
                    Valor = 100
                },
                Tributos = new TributosNFSe
                {
                    Municipal = new TributoMunicipal
                    {
                        ISSQN = TributoISSQN.OperaçãoTributavel,
                        TipoRetencaoISSQN = TipoRetencaoISSQN.NaoRetido,
                    },
                    Total = new TotalTributos
                    {
                        PorcentagemTotal = new PorcentagemTotalTributos()
                        {
                            TotalEstadual = 0,
                            TotalFederal = 0,
                            TotalMunicipal = 0,
                        }
                    }
                }
            };


            var dps = new Common.Dps();
            dps.Versao = "1.00";
            dps.Informacoes = new Common.InfDps()
            {
                Id = "DPS" + SetupOpenNFSeNacional.CodMun +
                            SetupOpenNFSeNacional.TipoInscricaoFederal +
                            SetupOpenNFSeNacional.InscricaoFederal.PadLeft(14, '0') +
                            SetupOpenNFSeNacional.SerieDPS.PadLeft(5, '0') +
                            SetupOpenNFSeNacional.NumDPS.PadLeft(15, '0'),
                TipoAmbiente = DFe.Core.Common.DFeTipoAmbiente.Homologacao,
                DhEmissao = DateTime.Now,
                LocalidadeEmitente = SetupOpenNFSeNacional.CodMun,
                Serie = SetupOpenNFSeNacional.SerieDPS,
                NumeroDps = SetupOpenNFSeNacional.NumDPS.ToInt32(),
                Competencia = DateTime.Now,
                TipoEmitente = EmitenteDps.Prestador,
                Prestador = prest,
                Tomador = toma,
                Servico = serv,
                Valores = valores
            };
            var retorno = await openNFSeNacional.EnviarAsync(dps);

            Assert.IsTrue(retorno.Sucesso);
        }
    }
}