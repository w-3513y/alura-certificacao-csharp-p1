namespace certificacao_csharp_roteiro.Aula_1___tipos_de_valor._1___Tipos_de_Valor._3___Tipos_de_Ponto_Flutuante
{
    class PontoFlutuante : IAulaItem
    {        

        public void Executar()
        {
            float valueFloat = float.MaxValue; //System.Single
            double valueDouble = double.MaxValue; //System.Double
            System.Console.WriteLine(valueFloat);
            System.Console.WriteLine(valueDouble);

            valueFloat = float.MinValue; //System.Single
            valueDouble = double.MinValue;
            System.Console.WriteLine(valueFloat);
            System.Console.WriteLine(valueDouble);

            int x = int.MaxValue;
            short y = short.MaxValue ;
            var result = x * y; //result vai ser int pois o dot net sempre cria a variável com o tipo da maior envolvida na operação
            System.Console.WriteLine(result);
            System.Console.WriteLine($"o dot net criou uma variável do tipo: {result.GetType()}");



        }
    }
}
