using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Serializer;

namespace OpenAC.Net.NFSe.Nacional.Common.Model.ISSNet;

public sealed class CadastroISSNet
{
    /// <summary>
    /// CNPJ do cadastro.
    /// </summary>
    [DFeElement(TipoCampo.StrNumber, "CNPJ", Min = 14, Max = 14, Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? CNPJ { get; set; }

    /// <summary>
    /// CPF do cadastro.
    /// </summary>
    [DFeElement(TipoCampo.StrNumber, "CPF", Min = 11, Max = 11, Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? CPF { get; set; }

    /// <summary>
    /// Inscricao municipal do cadastro.
    /// </summary>
    [DFeElement(TipoCampo.StrNumber, "IM", Min = 1, Max = 15, Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? InscricaoMunicipal { get; set; }

    /// <summary>
    /// Status do cadastro.
    /// </summary>
    [DFeElement(TipoCampo.Str, "StatusCadastro", Min = 1, Max = 60, Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? StatusCadastro { get; set; }

    /// <summary>
    /// Nome/razao social.
    /// </summary>
    [DFeElement(TipoCampo.Str, "xNome", Min = 1, Max = 300, Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? Nome { get; set; }

    /// <summary>
    /// Nome fantasia.
    /// </summary>
    [DFeElement(TipoCampo.Str, "xFant", Min = 1, Max = 150, Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? NomeFantasia { get; set; }

    /// <summary>
    /// Endereco nacional do cadastro.
    /// </summary>
    [DFeElement("enderNac", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public EnderecoEmitente? Endereco { get; set; }

    /// <summary>
    /// Telefone do cadastro.
    /// </summary>
    [DFeElement(TipoCampo.StrNumber, "fone", Min = 6, Max = 20, Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? Telefone { get; set; }

    /// <summary>
    /// Email do cadastro.
    /// </summary>
    [DFeElement(TipoCampo.Str, "email", Min = 1, Max = 80, Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? Email { get; set; }

    /// <summary>
    /// Indicador se emite NFS-e.
    /// </summary>
    [DFeElement(TipoCampo.Str, "EmiteNfse", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? EmiteNfse { get; set; }

    /// <summary>
    /// Indicador de permissoes de outras deducoes.
    /// </summary>
    [DFeElement(TipoCampo.Str, "PermiteOutrasDeducoes", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? PermiteOutrasDeducoes { get; set; }

    /// <summary>
    /// Indicador de desconto condicionado.
    /// </summary>
    [DFeElement(TipoCampo.Str, "PermiteDescontoCondicionado", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? PermiteDescontoCondicionado { get; set; }

    /// <summary>
    /// Indicador de desconto incondicionado.
    /// </summary>
    [DFeElement(TipoCampo.Str, "PermiteDescontoIncondicionado", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? PermiteDescontoIncondicionado { get; set; }

    /// <summary>
    /// Indicador de exigibilidade suspensa por decisao judicial.
    /// </summary>
    [DFeElement(TipoCampo.Str, "PermiteExigibilidadeSuspensaDecisaoJudicial", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? PermiteExigibilidadeSuspensaDecisaoJudicial { get; set; }

    /// <summary>
    /// Indicador de exigibilidade suspensa por processo administrativo.
    /// </summary>
    [DFeElement(TipoCampo.Str, "PermiteExigibilidadeSuspensaProcAdm", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? PermiteExigibilidadeSuspensaProcAdm { get; set; }

    /// <summary>
    /// Indicador de tributacao fora do municipio.
    /// </summary>
    [DFeElement(TipoCampo.Str, "PermiteTributarFora", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? PermiteTributarFora { get; set; }

    /// <summary>
    /// Dados de opcao pelo Simples Nacional.
    /// </summary>
    [DFeElement("OpcaoSimplesNacional", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public OpcaoSimplesNacionalISSNet? OpcaoSimplesNacional { get; set; }

    /// <summary>
    /// Dados de opcao pelo MEI.
    /// </summary>
    [DFeElement("OpcaoMei", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public OpcaoMeiISSNet? OpcaoMei { get; set; }

    /// <summary>
    /// Lista de atividades permitidas.
    /// </summary>
    [DFeElement("Atividades", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public AtividadesISSNet? Atividades { get; set; }

    /// <summary>
    /// Lista de tributacoes permitidas.
    /// </summary>
    [DFeElement("TributacoesPermitidas", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public TributacoesPermitidasISSNet? TributacoesPermitidas { get; set; }

    /// <summary>
    /// Lista de pessoas autorizadas a emitir.
    /// </summary>
    [DFeElement("PessoasAutorizadas", Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public PessoasAutorizadasISSNet? PessoasAutorizadas { get; set; }
}