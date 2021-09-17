namespace certificacao_csharp_roteiro.Aula_7___Tipos_Dinamicos._3___Resolucao_de_Sobrecarga
{
    class ResolucaoSobrecarga : IAulaItem
    {
        public void Executar()
        {
            int int1 = 123;
            int int2 = 456;

            short short1 = 122;
            short short2 = 456;

            double double1 = 123.45;
            double double2 = 456.78;

            string string1 = "abc";
            string string2 = "cde";

            System.Console.WriteLine(Somar(int1 , int2));
            System.Console.WriteLine(Somar(short1, short2));
            System.Console.WriteLine(Somar(double1, double2));
            System.Console.WriteLine(Somar(string1, string2));
        }

        //para efeito de execução o dynamic é tratado como object, por isso não é possível sobrecarga com os dois tipos
        dynamic Somar(dynamic parcela1, dynamic parcela2)
        {
            return parcela1 + parcela2;
        }

    }
}
