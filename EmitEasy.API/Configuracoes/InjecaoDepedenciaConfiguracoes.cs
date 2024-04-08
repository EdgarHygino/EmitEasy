using EmitEasy.Infra.Dados.Context;
using EmitEasy.Infra.Dados.Repositorios;
using EmitEasy.Infra.Services.ServicoUsuario;
using EmitEasy.Infra.Services;
using EmitEasy.Models.Interfaces;
using EmitEasy.Models.Interfaces.Services;
using EmitEasy.Models.Interfaces.Services.ServicoUsuario;
using Microsoft.EntityFrameworkCore;

namespace EmitEasy.API.Configuracoes
{
    public class InjecaoDepedenciaConfiguracoes
    {
        public void AddInjecaoDepedenciaConfig(IServiceCollection services)
        {
            services.AddDbContext<EmitEasyDbContext>(e => e.UseInMemoryDatabase("EmitEasyDb"));
            services.AddDbContext<UsuarioDbContext>(e => e.UseInMemoryDatabase("UsuarioDb"));
            services.AddSingleton<ServicoRabbitMq>();


            services.AddScoped<IClienteRepositorio, ClienteRepositorio>();
            services.AddScoped<IEmpresaRepositorio, EmpresaRepositorio>();
            services.AddScoped<INfseRepositorio, NfseRepositorio>();
            services.AddScoped<IServicoEvento, ServicoEvento>();
            services.AddScoped<IServicoUsuario, ServiceUsuario>();
            services.AddScoped<TokenService>();

        }
    }
}
