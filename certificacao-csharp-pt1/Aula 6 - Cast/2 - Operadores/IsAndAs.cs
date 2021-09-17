using certificacao_csharp_roteiro.Aula_2___tipos_de_referencia._1___Tipos_de_Referencia;
using certificacao_csharp_roteiro.Aula_4___sobrecargas._2___Metodos_Substituidos;

namespace certificacao_csharp_roteiro.Aula_6___Cast._2___Operadores
{
    class IsAndAs : IAulaItem
    {
        public void Executar()
        {
            Animal animal = new Animal();
            Gato gato = new Gato();
            Cliente cliente = new Cliente("José da Silva", 30);
            AlimentarUsandoOperadorIS(gato);
            ALimentarUsandoOperadorAs(animal);
            ALimentarUsandoOperadorAs(cliente);
        }

        public void ALimentarUsandoOperadorAs(object obj)
        {
            Animal animal = obj as Animal;
            //retorna nulo caso o objeto não seja do tipo 
            if (animal != null)
            {
                animal.Beber();
                animal.Comer();
            }
        }
        public void AlimentarUsandoOperadorIS(object obj)
        {
            if (obj is Animal animal) 
            {
                animal.Beber();
                animal.Comer();
            }
        }
    }
}
