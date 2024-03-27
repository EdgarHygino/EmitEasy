using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using EmitEasy.Models.Enums;

namespace EmitEasy.Models.Entities
{
    public class NotaFiscalServico
    {
        public NotaFiscalServico() 
        {
            IsDelete = false;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public int Rps { get; set; }

        [StringLength(50)]
        public string NumeroNfs { get; set; } = string.Empty;

        [Required]
        public int Serie { get; set; }

        [Required]
        public NaturezaOperacaoEnum NaturezaOperacao { get; set; }

        [Required]
        public string MunicipioIncidenciaIssqn { get; set; }

        [Required]
        public DateTime DataEmissao { get; set; }

        [StringLength(2000)]
        public string DescricaoServico { get; set; }

        [Required]
        public int ItemServico { get; set; }

        [Required]
        public bool ValorRetido { get; set; }

        [Required]
        public bool DescontarImposto { get; set; }

        [Column(TypeName = "numeric(10,2)")]
        public decimal ValorServico { get; set; }
        [Column(TypeName = "numeric(10,2)")]
        public decimal BaseCalculo { get; set; }
        [Column(TypeName = "numeric(10,2)")]
        public decimal Aliquota { get; set; }
        [Column(TypeName = "numeric(10,2)")]
        public decimal ValorDeducao { get; set; }
        [Column(TypeName = "numeric(10,2)")]
        public decimal Desconto { get; set; }
        [Column(TypeName = "numeric(10,2)")]
        public decimal AliquotaCofins { get; set; }
        [Column(TypeName = "numeric(10,2)")]
        public decimal AliquotaPis { get; set; }
        [Column(TypeName = "numeric(10,2)")]
        public decimal AliquotaCsll { get; set; }
        [Column(TypeName = "numeric(10,2)")]
        public decimal AliquotaIr { get; set; }
        [Column(TypeName = "numeric(10,2)")]
        public decimal AliquotaInss { get; set; }

        [Column(TypeName = "numeric(10,2)")]
        public decimal ValorCofins { get; set; }
        [Column(TypeName = "numeric(10,2)")]
        public decimal ValorPis { get; set; }
        [Column(TypeName = "numeric(10,2)")]
        public decimal ValorCsll { get; set; }
        [Column(TypeName = "numeric(10,2)")]
        public decimal ValorIr { get; set; }
        [Column(TypeName = "numeric(10,2)")]
        public decimal ValorInss { get; set; }

        [Column(TypeName = "numeric(10,2)")]
        public decimal ValorTotalNfse { get; set; }

        [StringLength(2000)]
        public string Observacao { get; set; } = string.Empty;

        public DateTime? DataCancelamento { get; set; }

        [Required]
        public bool IsDelete { get; set; }

        [Required]
        public Guid ClienteId { get; set; }

        [Required]
        public Guid EmpresaId { get; set; }

        [ForeignKey("EmpresaId")]
        public Empresa? Empresa { get; set; }

        [ForeignKey("ClienteId")]
        public Cliente? Cliente { get; set; }


        public void Update(
            int rps,
            string numeroNfs,
            int serie,
            NaturezaOperacaoEnum naturezaOperacao,
            string municipioIncidenciaIssqn,
            DateTime dataEmissao,
            string descricaoServico,
            int itemServico,
            bool valorRetido,
            bool descontarImposto,
            decimal valorServico,
            decimal baseCalculo,
            decimal aliquota,
            decimal valorDeducao,
            decimal desconto,
            decimal aliquotaCofins,
            decimal aliquotaPis,
            decimal aliquotaCsll,
            decimal aliquotaIr,
            decimal aliquotaInss,
            decimal valorCofins,
            decimal valorPis,
            decimal valorCsll,
            decimal valorIr,
            decimal valorInss,
            decimal valorTotalNfse,
            string observacao,
            DateTime? dataCancelamento,
            Guid clienteId,
            Guid empresaId)
        {
            Rps = rps;
            NumeroNfs = numeroNfs;
            Serie = serie;
            NaturezaOperacao = naturezaOperacao;
            MunicipioIncidenciaIssqn = municipioIncidenciaIssqn;
            DataEmissao = dataEmissao;
            DescricaoServico = descricaoServico;
            ItemServico = itemServico;
            ValorRetido = valorRetido;
            DescontarImposto = descontarImposto;
            ValorServico = valorServico;
            BaseCalculo = baseCalculo;
            Aliquota = aliquota;
            ValorDeducao = valorDeducao;
            Desconto = desconto;
            AliquotaCofins = aliquotaCofins;
            AliquotaPis = aliquotaPis;
            AliquotaCsll = aliquotaCsll;
            AliquotaIr = aliquotaIr;
            AliquotaInss = aliquotaInss;
            ValorCofins = valorCofins;
            ValorPis = valorPis;
            ValorCsll = valorCsll;
            ValorIr = valorIr;
            ValorInss = valorInss;
            ValorTotalNfse = valorTotalNfse;
            Observacao = observacao;
            DataCancelamento = dataCancelamento;
            ClienteId = clienteId;
            EmpresaId = empresaId;
        }

        public void Delete()
        {
            IsDelete = true;
            DataCancelamento = System.DateTime.Now;
        }

    }
}
