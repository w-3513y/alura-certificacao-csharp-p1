using System.Collections.Generic;

namespace certificacao_csharp_roteiro.Aula_3___metodos._4___Propriedades_Indexadas
{
    class PropriedadesIndexadas : IAulaItem
    {
        public void Executar()
        {
            var sala = new Sala();
            sala["D01"] = new ClienteCinema("Maria de Sousa");
            sala["D02"] = new ClienteCinema("José da Silva");
            sala.ImprimirReservas();
        }
    }

    class ClienteCinema
    {
        public string Nome { get; set; }
        public ClienteCinema(string nome)
        {
            Nome = nome;
        }

        public override string ToString()
        {
            return Nome;
        }
    }

    class Sala
    {
        private readonly IDictionary<string, ClienteCinema> reservas =
            new Dictionary<string, ClienteCinema>();

        //uma propriedade indexada não tem um nome
        public ClienteCinema this[string codigoAssento]
        {
            get
            {
                return reservas[codigoAssento];
            }
            set
            {
                reservas[codigoAssento] = value;
            }
        }

        public void ImprimirReservas()
        {
            System.Console.WriteLine("Assentos reservados");
            System.Console.WriteLine("===================");
            foreach (var reserva in reservas)
            {
                System.Console.WriteLine($"{reserva.Key} - {reserva.Value}");
            }
        }
    }
}