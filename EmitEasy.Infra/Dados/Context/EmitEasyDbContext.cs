using EmitEasy.Models.Entities;
using EmitEasy.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace EmitEasy.Infra.Dados.Context
{
    public class EmitEasyDbContext : DbContext
    {
        public EmitEasyDbContext(DbContextOptions <EmitEasyDbContext> opcoes) : base(opcoes)
        {
            
        }

        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<NotaFiscalServico> Nfse { get; set; }
    }
}
