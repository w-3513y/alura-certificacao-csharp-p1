namespace certificacao_csharp_roteiro.Aula_2___tipos_de_referencia._3___Interfaces
{
    class Interfaces : IAulaItem
    {
        public void Executar()
        {
            IEletro eletrodomestico = new Televisao();            
            System.Console.WriteLine(eletrodomestico.Ligar());
        }

        interface IEletro
        {
            string Ligar();
            string Desligar();
        }

        interface ITela
        {
            void AumentaBrilho(int brilho);
        }

        class Abajour : IEletro
        {
            public string Desligar()
            {
                return "Abajour desligada";
            }

            public string Ligar()
            {
                return "Abajour ligada";
            }
        }

        class Televisao : IEletro, ITela
        {

            public int Brilho { get; set; }
            public void AumentaBrilho(int brilho)
            {
                Brilho += brilho;
            }

            public string Desligar()
            {
                return "TV desligada";
            }

            public string Ligar()
            {
                return "TV ligada";
            }
        }

    }
}
