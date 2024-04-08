using Microsoft.Extensions.Configuration;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmitEasy.Infra.Services
{
    public class ServicoRabbitMq : IDisposable
    {
        public readonly IConnection _conexao;

        public ServicoRabbitMq(IConfiguration configuracao)
        {
            var fabrica = new ConnectionFactory()
            {
                HostName = configuracao["Mensageria:EndPoint"],
                UserName = configuracao["Mensageria:Usuario"],
                Password = configuracao["Mensageria:Senha"],

            };
            this._conexao = fabrica.CreateConnection(configuracao["Mensageria:NomeConexao"]);
        }

        public void FecharConexao()
        {
            _conexao?.Close();
        }

        public void Dispose()
        {
            Dispose(true);
        }
        protected virtual void Dispose(bool disposing)
        {
            _conexao?.Dispose();
        }
    }
}
