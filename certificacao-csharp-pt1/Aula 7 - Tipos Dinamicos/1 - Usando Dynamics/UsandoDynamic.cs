namespace certificacao_csharp_roteiro.Aula_7___Tipos_Dinamicos._1___Usando_Dynamics
{
    class UsandoDynamic : IAulaItem
    {
        public void Executar()
        {
            //o dinamico faz tudo em tempo de execução, por isso ele não precisa de cast
            string a = "certificação";
            var b = "certificação";
            object c = "certificação";
            dynamic d = "certificação";
            Imprimir(a, b, c, d);
            a = a.ToUpper();
            b = b.ToUpper();
            c = ((string)c).ToUpper();
            d = d.ToUpper();
            Imprimir(a, b, c, d);
            c = 123;
            d = 123;
            c = (int)c + 4;
            d += 4;
            Imprimir(a, b, c, d);
        }

        public void Imprimir(object a, object b, object c, object d)
        {
            System.Console.WriteLine(a);
            System.Console.WriteLine(b);
            System.Console.WriteLine(c);
            System.Console.WriteLine(d);
        }
    }
}
