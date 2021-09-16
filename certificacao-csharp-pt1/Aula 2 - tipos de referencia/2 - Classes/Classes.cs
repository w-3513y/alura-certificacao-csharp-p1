using certificacao_csharp_roteiro.Aula_1___tipos_de_valor._1___Tipos_de_Valor._6___Structs;
using System;

namespace certificacao_csharp_roteiro.Aula_2___tipos_de_referencia._2___Classes
{
    class Classes : IAulaItem
    {
        public void Executar()
        {
            GlobalPositions posicao;
            //posicao.Latitude = 13.78; -- essa linha dá erro pq não é possível utilizar uma instância de uma classe sem antes instanciar um objeto para essa variável

            posicao = new GlobalPositions(15.7, 18.3);

            GlobalPositions posicao1 = new GlobalPositions() { Latitude = 13.77, Longitude = 28.66 };

            GPS posicao2 = new GPS(15.7, 18.5, System.DateTime.Now);

            System.Console.WriteLine(posicao.ToString());
            System.Console.WriteLine(posicao.IsNorthhemisphere());
            System.Console.WriteLine(posicao1.ToString());
            System.Console.WriteLine(posicao2.ToString());



        }

        internal class GlobalPositions : IGPS
        {
            public double Latitude { get; set; }
            public double Longitude { get; set; }


            public GlobalPositions()
            {
                //diferente de struct class permite um construtor vazio
            }

            public GlobalPositions(double latitude, double longitude)
            {
                Latitude = latitude;
                Longitude = longitude;
            }

            public override string ToString()
            {
                return $"latitude: {Latitude}, longitude {Longitude}";
            }

            public bool IsNorthhemisphere()
            {
                return (Latitude > 0);
            }
        }

        public class GPS : GlobalPositions
        {
            private System.DateTime DataReader { get; set; }

            public GPS(double latitude, double longitude, DateTime dataReader) :base(latitude, longitude)
            {
                DataReader = dataReader;
            }

            public override string ToString()
            {
                return $"latitude: {Latitude}, longitude {Longitude}, data captura: {DataReader}";
            }
        }

    }
}
