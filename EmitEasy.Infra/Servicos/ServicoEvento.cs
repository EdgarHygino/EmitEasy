using EmitEasy.Models.Interfaces;
using RabbitMQ.Client;
using System.Text;
using Newtonsoft.Json;
using RabbitMQ.Client.Exceptions;

namespace EmitEasy.Infra.Servicos
{
    public class ServicoEvento: IServicoEvento
    {
        private readonly INfseRepositorio _nfseRepositorio;
        private readonly ServicoRabbitMq _servicoRabbitMq;

        public ServicoEvento(INfseRepositorio nfseRepositorio, ServicoRabbitMq servicoRabbitMq)
        {
            _nfseRepositorio = nfseRepositorio;
            _servicoRabbitMq = servicoRabbitMq;
        }

        public void EnviarEvento(Guid id)
        {
            try
            {
                var nfse = _nfseRepositorio.GetById(id);

                
                var connection = _servicoRabbitMq._conexao;
                using var channel = connection.CreateModel();

                channel.QueueDeclare(queue: "nfse",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var jsonSerealizado = JsonConvert.SerializeObject(nfse);
                var body = Encoding.UTF8.GetBytes(jsonSerealizado);


                channel.BasicPublish(exchange: string.Empty,
                                 routingKey: "nfse",
                                 basicProperties: null,
                                 body: body);
            }
            catch (BrokerUnreachableException ex)
            {
                Console.WriteLine("Erro de conexão com o RabbitMQ: " + ex.Message);
            }
            catch (AuthenticationFailureException ex)
            {
                Console.WriteLine("Falha de autenticação com o RabbitMQ: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao enviar evento: " + ex.Message);
            }

            

        }
        
    }
}
