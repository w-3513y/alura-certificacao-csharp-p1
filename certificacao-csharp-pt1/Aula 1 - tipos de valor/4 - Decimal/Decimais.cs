namespace certificacao_csharp_roteiro.Aula_1___tipos_de_valor._1___Tipos_de_Valor._4___Decimal
{
    class Decimais : IAulaItem
    {
        public void Executar()
        {
            double doublevr1 = 10.1;
            double doublevr2 = 20.2;
            double doubletotal = 30.3;
            System.Console.WriteLine($"Testando cálculos com decimais usando double, verificando se {doublevr1} + {doublevr2} = {doubletotal}");

            System.Console.WriteLine((doublevr1 + doublevr2) == doubletotal); //da false pq o double guarda os números como binários e só quando retorna eles é que arredonda


            decimal decimalvr1 = 10.1m; //System.Decimal -- melhor para valores monetários
            decimal decimalvr2 = 20.2m;
            decimal decimaltotal = 30.3m;
            System.Console.WriteLine($"Testando cálculos com decimais usando double, verificando se {decimalvr1} + {decimalvr2} = {decimaltotal}");

            System.Console.WriteLine((decimalvr1 + decimalvr2) == decimaltotal);
        }
    }
}
