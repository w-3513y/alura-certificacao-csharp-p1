using certificacao_csharp_roteiro.Aula_4___sobrecargas._2___Metodos_Substituidos;

namespace certificacao_csharp_roteiro.Aula_6___Cast
{
    class ConversoesImplicitas : IAulaItem
    {
        public void Executar()
        {
            int inteiro = 2123456789;
            //a conversão implícita é possível pq o escopo do long é maior que o do tipo int, o inverso não é possível
            long inteiroLong = inteiro;
            System.Console.WriteLine(inteiroLong);

            Gato gato = new Gato();
            //conversão implícita só é possível pq gato é uma classe que herda do tipo animal, o inverso não é possível
            Animal animal = gato;
            System.Console.WriteLine(animal);            
        }
    }
}

//Tabela de Conversões numéricas implícitas
//=================
//De      Para
//=================
//sbyte   short, int, long, float, double, decimal   
//byte    short, ushort, int, uint, long, ulong, float, double, decimal
//short   int, long, float, double, decimal
//ushort  int, uint, long, ulong, float, double, decimal
//int     long, float, double, decimal
//long    float, double, decimal
//char    ushort, int, uint, long, ulong, float, double, decimal
//float   double
//ulong   float, double, decimal
//double  (nenhum)
//decimal (nenhum)