using System.Collections.Generic;

namespace certificacao_csharp_roteiro.Aula_7___Tipos_Dinamicos._2___Convertendo_Dynamics
{
    class ConvertendoDynamic : IAulaItem
    {
        public void Executar()
        {
            dynamic a = 7;
            dynamic b = "88";
            dynamic c = System.DateTime.Now;
            dynamic d = new List<int>() { 1, 2, 3 };
            Imprimir(new List<object> { a, b, c, d });
            //conversão implicita
            int a1 = a;
            string b1 = b;
            System.DateTime c1 = c;
            List<int> d1 = d;

            Imprimir(new List<object> { a1, b1, c1, d1});

            //conversão explicita
            int b2 = int.Parse(b);

            Imprimir(new List<object> { b2 });
        }

        public void Imprimir(List<object> objs)
        {
            foreach(var obj in objs)
            {
                System.Console.WriteLine(obj);
            }           
        }
    }
}
