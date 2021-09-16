namespace certificacao_csharp_roteiro.Aula_4___sobrecargas._1___Metodos_Sobrecarregados
{
    class Sobrecargas : IAulaItem
    {
        public void Executar()
        {
            //Volume do Cubo = lado ^ 3
            int lado = 3;
            System.Console.WriteLine($"Volume do Cubo: {Volume(lado)}");
            //Volume do Cilindro = altura * Pi * raio ^ 2
            double raio = 2;
            int altura = 10;
            System.Console.WriteLine($"Volume do Cilindro: {Volume(altura, raio)}");
            //Volume do Prisma = largura * profundidade * altura
            long largura = 10;
            altura = 6;
            int profundidade = 4;
            System.Console.WriteLine($"Volume do Prisma: {Volume(largura, profundidade, altura)}");

        }
        //a sobrecarga permite que eu sobrecarregue os métodos desde que eu mude a assinatura de parâmetros
        //Ela permite a existência de vários métodos de mesmo nome, porém com assinaturas que variam no número, ordem e tipo dos parâmetros.
        double Volume(double lado)
        {
            return System.Math.Pow(lado, 3);
        }

        double Volume(double altura, double raio)
        {
            return altura * System.Math.PI * System.Math.Pow(raio, 2);
        }

        double Volume(double largura, double profundidade, double altura)
        {
            return largura * profundidade * altura;
        }
    }
}
