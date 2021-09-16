namespace certificacao_csharp_roteiro.Aula_1___tipos_de_valor._1___Tipos_de_Valor._7___Enums
{
    class Enums : IAulaItem
    {
        public void Executar()
        {
            DaysOfWeek firstDay = DaysOfWeek.Monday;

            System.Console.WriteLine(firstDay);
        }

        [System.Flags]
        enum DaysOfWeek
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
    }
}