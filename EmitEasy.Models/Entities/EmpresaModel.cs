using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmitEasy.Models.Models
{
    public class EmpresaModel
    {
        public EmpresaModel()
        {
            Ativo = false;
        }

        public Guid Id { get; set; }

        public string RazaoSocial { get; set; }

        public string NomeFantasia { get; set;}

        public string Cnpj { get; set;}

        public string InscricaoEstadual { get; set;} = string.Empty;

        public string InscricaoMunicial { get; set; } = string.Empty;

        public bool Ativo { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Celular { get; set; }

        public int Cep { get; set; }

        public string Rua { get; set; }

        public string Numero { get; set; }

        public string Cidade { get; set; }

        public string Pais { get; set; }

        public string Bairro { get; set; }

        public string Estado { get; set; }

        public string Complemento { get; set; } = string.Empty;

        public int CodMunicipio { get; set; }



        public void Update(string razaoSocial, string nomeFantasia, string inscricaoEstadual, string inscricaoMunicial, string nome,
        string descricao, string email, string telefone, string celular, int cep, string rua, string numero, string cidade, string pais,
        string bairro, string estado, string complemento, int codMunicipio)
        {
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            InscricaoEstadual = inscricaoEstadual;
            InscricaoMunicial = inscricaoMunicial;
            Nome = nome;
            Descricao = descricao;
            Email = email;
            Telefone = telefone;
            Celular = celular;
            Cep = cep;
            Rua = rua;
            Numero = numero;
            Cidade = cidade;
            Pais = pais;
            Bairro = bairro;
            Estado = estado;
            Complemento = complemento;
            CodMunicipio = codMunicipio;

        }

        public void Delete()
        {
            Ativo = true;
        }

    }

    
}
