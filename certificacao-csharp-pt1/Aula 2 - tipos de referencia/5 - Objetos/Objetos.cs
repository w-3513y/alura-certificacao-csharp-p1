using static certificacao_csharp_roteiro.Aula_2___tipos_de_referencia._2___Classes.Classes;

namespace certificacao_csharp_roteiro.Aula_2___tipos_de_referencia._5___Objetos
{
    class Objetos : IAulaItem
    {
        public void Executar()
        {
            int valor = 4;
            object meuObjeto;

            meuObjeto = valor;
            //objeto recebendo uma variável do tipo valor
            System.Console.WriteLine(valor);
            System.Console.WriteLine(meuObjeto);
            //objeto recebendo variável do tipo referencia
            meuObjeto = new GPS(15.7, 18.5, System.DateTime.Now);
            System.Console.WriteLine(meuObjeto);
        }
    }
}
