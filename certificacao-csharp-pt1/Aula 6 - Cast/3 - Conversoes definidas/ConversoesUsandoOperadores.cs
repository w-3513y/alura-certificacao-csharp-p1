namespace certificacao_csharp_roteiro.Aula_6___Cast._3___Conversoes_definidas
{
    class ConversoesUsandoOperadores : IAulaItem
    {
        public void Executar()
        {
            AnguloEmGraus anguloEmGraus = 45;
            System.Console.WriteLine(anguloEmGraus);

            AngulosEmRadianos angulosEmRadianos = 15;
            System.Console.WriteLine(angulosEmRadianos);

            double graus = anguloEmGraus;
            System.Console.WriteLine(graus);

            angulosEmRadianos = (AngulosEmRadianos)anguloEmGraus;
            anguloEmGraus = angulosEmRadianos;
            System.Console.WriteLine($"angulo em graus: {anguloEmGraus}");
            System.Console.WriteLine($"angulo em graus: {angulosEmRadianos}");
        }

        public struct AngulosEmRadianos
        {
            public double Radianos { get; }
            public AngulosEmRadianos(double radianos)
            {
                Radianos = radianos;
            }
            //a palavra reservada explicit indica que para a conversão é necessário fazer o Cast da variável
            public static explicit operator AngulosEmRadianos(AnguloEmGraus graus)
            {
                return new AngulosEmRadianos(graus.Graus * System.Math.PI / 180);
            }

            //a palavra reservada implicit indica que a conversão vai ser implicita
            public static implicit operator AngulosEmRadianos(double graus)
            {
                return new AngulosEmRadianos(graus);
            }

            public static implicit operator double(AngulosEmRadianos angulosEmRadianos)
            {
                return angulosEmRadianos.Radianos;
            }

            public override string ToString()
            {
                return string.Format("{0} radianos", this.Radianos);
            }
        }

        public struct AnguloEmGraus
        {
            public double Graus { get; }
            public AnguloEmGraus(double graus)
            {
                Graus = graus;
            }

            public static implicit operator AnguloEmGraus(AngulosEmRadianos radianos)
            {
                return new AnguloEmGraus(radianos.Radianos * 180 / System.Math.PI);
            }

            public static implicit operator AnguloEmGraus(double graus)
            {
                return new AnguloEmGraus(graus);
            }

            public static implicit operator double(AnguloEmGraus anguloEmGraus)
            {
                return anguloEmGraus.Graus;
            }
            public override string ToString()
            {
                return string.Format("{0} graus", this.Graus);
            }

        }
    }
}

