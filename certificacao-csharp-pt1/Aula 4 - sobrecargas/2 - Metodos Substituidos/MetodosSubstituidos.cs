namespace certificacao_csharp_roteiro.Aula_4___sobrecargas._2___Metodos_Substituidos
{
    class MetodosSubstituidos : IAulaItem
    {
        public void Executar()
        {
            Animal gato = new Gato() { Nome = "Bichano" };
            gato.Beber();
            gato.Andar();
            gato.Comer();

            Animal gato2 = new Gato() { Nome = "Miau" };
            gato2.Beber();
            gato2.Andar();
            gato2.Comer();
        }
    }

    class Animal
    {
        public string Nome { get; set; }
        
        public void Beber()
        {
            System.Console.WriteLine("Animal bebendo");
        }
        
        public virtual void Comer()
        {
            System.Console.WriteLine("Animal comendo");
        }
        
        public void Andar()
        {
            System.Console.WriteLine("Animal andando");
        }
    }

    class Gato : Animal
    {
        public new void Beber() //new só irá funcionar na classe derivada
        {
            System.Console.WriteLine("Gato bebendo");
        }

        public override void Comer() //override sobrescreve a classe base
        {
            System.Console.WriteLine("Gato comendo");
        }

        public new void Andar()
        {
            System.Console.WriteLine("Gato andando");
        }

    }
}
