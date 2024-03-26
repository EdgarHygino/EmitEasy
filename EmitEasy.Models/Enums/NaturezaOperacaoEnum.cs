using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmitEasy.Models.Enums
{
    public enum NaturezaOperacaoEnum
    {

        [Description("Tributação no município")] TributacaoMunicipio = 1,

        [Description("Tributação fora do município")] TributacaoForaMunicipio = 2,

        [Description("Isenção")] Isencao = 3,

        [Description("Imune")] Imune = 4,

        [Description("Exigibilidade suspensa por decisão judicial")] ExigibilidadeSuspencaJudicial = 5,

        [Description("Exigibilidade suspensa por procedimento administrativo")]
        ExigibilidadeSuspencaAdm = 6


    }
}
