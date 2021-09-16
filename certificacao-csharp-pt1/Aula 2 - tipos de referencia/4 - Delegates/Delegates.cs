namespace certificacao_csharp_roteiro.Aula_2___tipos_de_referencia._4___Delegates
{
    class Delegates : IAulaItem
    {
        public void Executar()
        {
            Calculadora.Executar();
        }
        //Delegates são como ponteiros para métodos.Eles são usados geralmente para implementar eventos e métodos de call-back.
        delegate double MetodoDelegate(double x);

        static class Calculadora
        {
            static public double Somar(double x)
            {
                return x + 1;
            }

            static public double Multiplicar(double x)
            {
                return x * 2;
            }

            static public void Executar()
            {
                MetodoDelegate vardelegada = Multiplicar;
                System.Console.WriteLine(vardelegada(4));
                vardelegada = Somar;
                System.Console.WriteLine(vardelegada(3));
                //instanciar um delegate com método anônimo
                MetodoDelegate metodoQuadrado = delegate (double x)
                {
                    return x * x;
                };
                System.Console.WriteLine(metodoQuadrado(5));
                //usando lambda
                MetodoDelegate metodoCubo = input => input * input * input;
                System.Console.WriteLine(metodoCubo(5));
            }
        }
    }
}