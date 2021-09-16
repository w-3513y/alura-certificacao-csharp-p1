using System;

namespace certificacao_csharp_roteiro.Aula_1___tipos_de_valor._1___Tipos_de_Valor._1___Tipos_de_Valor
{
    class TiposDeValor : IAulaItem
    {
        public void Executar()
        {
            int idade = 30;            

            System.Int32 copiaIdade = idade;

            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"copiaIdade: {copiaIdade}");

            idade = 23;

            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"copiaIdade: {copiaIdade}");

           // int? idade2 = null;

            System.Nullable<int> idade3 = null;

            Console.WriteLine(idade3);
        }
    }
}
