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

        public double valorCofins { get; set; }
        public double valorPis { get; set; }
        public double valorCsll { get; set; }
        public double valorIr { get; set; }
        public double valorInss { get; set; }

        public double valorTotalNfse { get; set; }

        public string Observacao { get; set; }

        public DateTime DataCancelamento { get; set; }

        public bool IsDelete { get; set; }
    }
}
