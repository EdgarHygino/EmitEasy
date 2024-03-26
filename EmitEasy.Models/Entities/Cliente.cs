using EmitEasy.Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmitEasy.Models.Entities
{
    public class Cliente
    {
        public Cliente()
        {
            Ativo = true;
            TipoCliente = "J";
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [StringLength(100)]
        public string RazaoSocial { get; set; }

        [StringLength(100)]
        public string NomeFantasia { get; set; }

        [StringLength(18)]
        public string Cnpj { get; set; }

        [StringLength(50)]
        public string InscricaoEstadual { get; set; } = string.Empty;

        [StringLength(50)]
        public string InscricaoMunicial { get; set; } = string.Empty;

        [StringLength(1)]
        public string TipoCliente { get; set; }

        [Required]
        public bool Ativo { get; set; }

        [StringLength(100)]
        public string Nome { get; set; } = string.Empty;

        [StringLength(1000)]
        public string Descricao { get; set; } = string.Empty;

        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(11)]
        public string Telefone { get; set; } = string.Empty;

        [StringLength(11)]
        public string Celular { get; set; } = string.Empty;

        [StringLength(8)]
        public string Cep { get; set; }

        [StringLength(100)]
        public string Rua { get; set; }

        [StringLength(30)]
        public string Numero { get; set; }

        [StringLength(50)]
        public string Cidade { get; set; }

        [StringLength(50)]
        public string Pais { get; set; }

        [StringLength(50)]
        public string Bairro { get; set; }

        [StringLength(50)]
        public string Estado { get; set; }

        [StringLength(100)]
        public string Complemento { get; set; } = string.Empty;

        public int CodMunicipio { get; set; }

        public void Update(string razaoSocial, string nomeFantasia, string inscricaoEstadual, string inscricaoMunicial, string nome,
       string descricao, string email, string telefone, string celular, string cep, string rua, string numero, string cidade, string pais,
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
            Ativo = false;
        }
    }
}
