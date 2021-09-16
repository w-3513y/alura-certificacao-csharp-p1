namespace certificacao_csharp_roteiro.Aula_2___tipos_de_referencia._6__Dynamic
{
    class Dinamicos : IAulaItem
    {
        public void Executar()
        {
            //A existência dos membros de um objeto dynamic são verificados somente em tempo de execução.
            //Uma variável declarada como dynamic pode conter os mesmo tipos que um uma variável object, incluindo os tipos de valor.
            //As variáveis do tipo dynamic são compiladas em variáveis do tipo object
            //O compilador nunca avalia uma expressão com tipo dynamic
            //O tipo dynamic existe somente em tempo de compilação e não em tempo de execução.
            //Operações que contêm expressões dynamic não são resolvidas ou verificadas pelo compilador.
            //é um tipo abstrato que recebe qualquer valor
            dynamic dinamico = 1;
            dinamico += 3;
            dynamic dinamico2 = dinamico;
            System.Console.WriteLine(dinamico);
            System.Console.WriteLine(dinamico2);

            dinamico = "teste";

            System.Console.WriteLine(dinamico);
            System.Console.WriteLine(dinamico2); //não muda o valor mesmo passando como referência
        }
    }
}
