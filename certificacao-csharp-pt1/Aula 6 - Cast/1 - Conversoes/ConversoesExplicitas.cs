using certificacao_csharp_roteiro.Aula_4___sobrecargas._2___Metodos_Substituidos;

namespace certificacao_csharp_roteiro.Aula_6___Cast
{
    class ConversoesExplicitas : IAulaItem
    {
        public void Executar()
        {
            double divida = 3150.77;
            //ao fazer o cast o compilador irá truncar o valor
            long salario = (long)divida;
            double teste = long.MaxValue;//double.MaxValue;
            teste++;
            //como o valor estoura o limite da variável do tipo long, o compilador irá retornar o MinValue do tipo
            long teste2 = (long)teste;
            System.Console.WriteLine(salario);
            System.Console.WriteLine(teste2);
            //obs: se a instancia do animal fosse new Animal() isso daria um erro em tempo de execução
            Animal animal = new Gato();
            Gato gato = (Gato)animal;
            System.Console.WriteLine(gato);
        }
    }
}
