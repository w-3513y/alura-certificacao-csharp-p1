namespace certificacao_csharp_roteiro.Aula_2___tipos_de_referencia._1___Tipos_de_Referencia
{
    class TiposDeReferencia : IAulaItem
    {
        public void Executar()
        {
            var cliente1 = new Cliente("José", 32);
            //conceito de ponteiros >>>
            var cliente2 = cliente1; //não faz uma cópia independente, faz uma referencia a um objeto que está em outro lugar da memória
            System.Console.WriteLine($"cliente1: {cliente1}");
            System.Console.WriteLine($"cliente2: {cliente2}");

            cliente1.Nome = "Maria"; //como cliente2 é um tipo de referencia, irá ser alterado tbm
            cliente1.Idade = 29;

            System.Console.WriteLine($"cliente1: {cliente1}");
            System.Console.WriteLine($"cliente2: {cliente2}"); 

        }
    }

    class Cliente
    {
        public Cliente(string nome, int idade)
        {
            Nome = nome;
            Idade = idade; 
        }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}";
        }

    }
}
