using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;
using System;
using System.Threading;
using mantencion.Data;

// RRHH
// turno = IDisposable trabajador , fecha, horas trabajadas
// trabajador = RuntimeTypeHandle , nombre, apellido

namespace mantencion.RabbitMQ {
    

    public static class QueueProducer{
        public static void publicarMantencion(Mecanico mecanico, int horas, string fecha){

            var factory = new ConnectionFactory() { HostName = "localhost" };
            
            using (var connection = factory.CreateConnection())

            using (var channel = connection.CreateModel()){

                channel.ExchangeDeclare(
                    exchange: "mantencion",
                    type: "direct"
                    );

                var message = new {
                    nombre = mecanico.nombre,
                    apellido = mecanico.apellido,
                    rut = mecanico.rut,
                    horas = horas,
                    fecha = fecha,
                };

                var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(message));

                channel.BasicPublish(exchange: "mantencion",
                                        routingKey: "rrhh",
                                        basicProperties: null,
                                        body: body
                                    );
                // DecodeHelper decodeHelper = JsonConvert.DeserializeObject<DecodeHelper>(Encoding.UTF8.GetString(body));

                

                Console.WriteLine(message);
        
            }

        }
        
    }

}