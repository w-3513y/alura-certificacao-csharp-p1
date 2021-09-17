namespace certificacao_csharp_roteiro.Aula_5___box._1___Boxing
{
    class Unboxing : IAulaItem
    {
        public void Executar()
        {
            object boxed = 57;
            short unboxed = (short)boxed; //unboxing
            System.Console.WriteLine(unboxed);
        }

        public static void ImprimirSaldo(decimal quantia)
        {
            object quantiaref = quantia;
            int saldo = (int)(decimal)quantiaref; //duas conversões são necessárias quando o unboxing é feito em um objeto com tipo diferente
            System.Console.WriteLine(saldo);
        }
    }
}
