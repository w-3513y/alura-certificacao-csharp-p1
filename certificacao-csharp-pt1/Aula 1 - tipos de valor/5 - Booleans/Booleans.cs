namespace certificacao_csharp_roteiro.Aula_1___tipos_de_valor._1___Tipos_de_Valor._5___Booleans
{
    class Booleans : IAulaItem
    {
        public void Executar()
        {
            bool isTrue = false; //System.Boolean            

            System.Console.WriteLine($"é verdadeiro: {isTrue}");

            bool isDivisibleBy2 = (System.DateTime.Now.Day % 2 == 0);

            if (isDivisibleBy2)
            {
                System.Console.WriteLine($"today {System.DateTime.Now.Day} é divisível por 2");
            }
        }
    }
}
