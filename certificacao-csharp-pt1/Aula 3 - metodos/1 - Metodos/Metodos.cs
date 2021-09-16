namespace certificacao_csharp_roteiro.Aula_3___metodos._1___Metodos
{
    class Metodos : IAulaItem
    {
        public void Executar()
        {
            Retangulo retangulo = new Retangulo(4, 8);
            Retangulo retanguloCompare = new Retangulo(6, 12);
            System.Console.WriteLine($"Area do retângulo: {retangulo.Area}");
            System.Console.WriteLine(retangulo.RetanguloSemelhante(retanguloCompare));

        }

        class Retangulo
        {
            public double Altura { get; set; }
            public double Largura { get; set; }
            public double Area { get => GetArea(); }

            public Retangulo(double altura, double largura)
            {
                Altura = altura;
                Largura = largura;
            }

            public override string ToString()
            {
                return $"altura: {Altura}, largura: {Largura}";
            }

            private double GetArea()
            {
                return Altura * Largura;
            }

            internal bool RetanguloSemelhante(Retangulo outroRetangulo)
            {
                //por ser um parametro do tipo referência, qualquer alteração feita no objeto outroRetangulo irá refletir no objeto que foi enviado como parâmetro
                return ((Largura / Altura) == (outroRetangulo.Largura / outroRetangulo.Altura)) ||
                ((Altura / Largura) == (outroRetangulo.Altura / outroRetangulo.Largura));
            }

            internal bool RetanguloSemelhante(double outroRetanguloAltura, double outroRetanguloLargura)
            {
                return ((Largura / Altura) == (outroRetanguloLargura / outroRetanguloAltura)) ||
                ((Altura / Largura) == (outroRetanguloAltura / outroRetanguloLargura));
            }

            internal static bool RetanguloSemelhante(Retangulo retangulo1, Retangulo retangulo2)
            {
                //metodos estáticos não tem acesso aos componentes da classe
                return ((retangulo1.Largura / retangulo1.Altura) == (retangulo2.Largura / retangulo2.Altura)) ||
                ((retangulo1.Altura / retangulo1.Largura) == (retangulo2.Altura / retangulo2.Largura));
            }

            //Tipos de modificadoras:
            //private: só podemos acessar esse método de dentro da própria classe.  -- é o padrão se nenhum outro for declarado
            //internal: pode ser acessado apenas a partir do mesmo assembly;
            //public: não faz restrição nenhuma de acesso, ficaria acessível tanto de dentro quanto de fora de nosso projeto.
            // protected: pode ser acessado somente pelo código na mesma classe ou em uma classe derivada dessa classe
        }
    }
}
