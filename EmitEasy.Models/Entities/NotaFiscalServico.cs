using EmitEasy.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmitEasy.Models.Entities
{
    public class NotaFiscalServico
    {
        public NotaFiscalServico() 
        {
            IsDelete = false;
        }

        public Guid Id { get; set; }

        public string TipoNota { get; set; }

        public int Rps { get; set; }

        public string NumeroNfs { get; set; }

        public int Serie { get; set; }

        public int NaturezaOperacao { get; set; }

        public string MunicipioIncidenciaIssqn { get; set; }

        public DateTime DataEmissao { get; set; }

        public string TipoCliente { get; set; }

        public string DescricaoServico { get; set; }

        public int ItemServico { get; set; }

        public bool ValorRetido { get; set; }

        public bool DescontarImposto { get; set; }

        public double ValorServico { get; set; }
        public double BaseCalculo { get; set; }
        public double Aliquota { get; set; }
        public double ValorDeducao { get; set; }
        public double Desconto { get; set; }
        public double AliquotaCofins { get; set; }
        public double AliquotaPis { get; set; }
        public double AliquotaCsll { get; set; }
        public double AliquotaIr { get; set; }
        public double AliquotaInss { get; set; }

        public double ValorCofins { get; set; }
        public double ValorPis { get; set; }
        public double ValorCsll { get; set; }
        public double ValorIr { get; set; }
        public double ValorInss { get; set; }

        public double ValorTotalNfse { get; set; }

        public string Observacao { get; set; }

        public DateTime DataCancelamento { get; set; }

        public bool IsDelete { get; set; }

        public int ClienteId { get; set; }

        public int EmpresaId { get; set; }

        public Empresa Empresa { get; set; }

        public Cliente Cliente { get; set; }


        public void Update(
            string tipoNota,
            int rps,
            string numeroNfs,
            int serie,
            int naturezaOperacao,
            string municipioIncidenciaIssqn,
            DateTime dataEmissao,
            string tipoCliente,
            string descricaoServico,
            int itemServico,
            bool valorRetido,
            bool descontarImposto,
            double valorServico,
            double baseCalculo,
            double aliquota,
            double valorDeducao,
            double desconto,
            double aliquotaCofins,
            double aliquotaPis,
            double aliquotaCsll,
            double aliquotaIr,
            double aliquotaInss,
            double valorCofins,
            double valorPis,
            double valorCsll,
            double valorIr,
            double valorInss,
            double valorTotalNfse,
            string observacao,
            DateTime dataCancelamento,
            bool isDelete,
            int clienteId,
            int empresaId)
        {
            TipoNota = tipoNota;
            Rps = rps;
            NumeroNfs = numeroNfs;
            Serie = serie;
            NaturezaOperacao = naturezaOperacao;
            MunicipioIncidenciaIssqn = municipioIncidenciaIssqn;
            DataEmissao = dataEmissao;
            TipoCliente = tipoCliente;
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
        }

    }
}
