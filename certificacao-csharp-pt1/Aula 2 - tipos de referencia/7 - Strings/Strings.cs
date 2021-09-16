namespace certificacao_csharp_roteiro.Aula_2___tipos_de_referencia._7___Strings
{
    class Strings : IAulaItem
    {
        public void Executar()
        {
            string a = "teste";
            string b = a;
            System.Console.WriteLine(a);
            System.Console.WriteLine(b);
            System.Console.WriteLine(a[3]); //string pode ser entendido como um array de chars
            a = "mudando";
            System.Console.WriteLine(a);
            System.Console.WriteLine(b);
            //apesar de ser um tipo de referência a string não muda o valor pois é uma sealed class, sealed é um modificador que impede que outras classes herdem dela
            //sealed pode ser usado em métodos para impedir que uma classe deverivada não use o modificador override em um método virtual da classe base

        }
    }
}
