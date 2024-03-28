using EmitEasy.Infra.Dados.Context;
using EmitEasy.Infra.Dados.Repositorios;
using EmitEasy.Infra.Servicos;
using EmitEasy.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EmitEasy.API.Configuracoes
{
    public class InjecaoDepedenciaConfiguracoes
    {
        public void AddInjecaoDepedenciaConfig(IServiceCollection services)
        {
            services.AddDbContext<EmitEasyDbContext>(e => e.UseInMemoryDatabase("EmitEasyDb"));
            services.AddSingleton<ServicoRabbitMq>();


            services.AddScoped<IClienteRepositorio, ClienteRepositorio>();
            services.AddScoped<IEmpresaRepositorio, EmpresaRepositorio>();
            services.AddScoped<INfseRepositorio, NfseRepositorio>();
            services.AddScoped<IServicoEvento, ServicoEvento>();

        }
    }
}
