namespace certificacao_csharp_roteiro.Aula_1___tipos_de_valor._1___Tipos_de_Valor._6___Structs
{
    class Structs : IAulaItem
    {
        public void Executar()
        {
            GlobalPositions posicao;
            posicao.Latitude = 13.78;
            posicao.Longitude = 29.51;

            GlobalPositions posicao1 = new GlobalPositions(15.7, 18.3);

            GlobalPositions posicao2 = new GlobalPositions() { Latitude = 13.77, Longitude = 28.66 };

            System.Console.WriteLine(posicao.ToString());
            System.Console.WriteLine(posicao1.ToString());
            System.Console.WriteLine(posicao2.ToString());
            System.Console.WriteLine(posicao.IsNorthhemisphere());

        }
    }

    interface IGPS
    {
        bool IsNorthhemisphere();
    }

    struct GlobalPositions : IGPS
    {
        public double Latitude;
        public double Longitude;

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
}
