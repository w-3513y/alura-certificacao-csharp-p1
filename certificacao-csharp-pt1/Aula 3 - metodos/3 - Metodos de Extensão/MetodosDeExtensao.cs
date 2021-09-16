namespace certificacao_csharp_roteiro.Aula_3___metodos._3___Metodos_de_Extensão
{
    class MetodosDeExtensao : IAulaItem
    {
        public void Executar()
        {
            
            Impressora impressora = new Impressora("Este é\r\no meu documento");
            impressora.Imprimir();
            impressora.ImprimirHTML();
        }

    }

    class Impressora
    {
        public string Impressao { get; }
        public Impressora(string impressao)
        {
            Impressao = impressao;
        }

        public void Imprimir()
        {
            System.Console.WriteLine();
            System.Console.WriteLine(Impressao);
        }
    }

    static class ImpressoraExtensions
    {
        //metodos de extensão são utilizados pra extender métodos de classes que vc não tem acesso, classes do dot net, por exemplo
        //métodos de extensão devem ser implementados em uma classe pública e estática
        public static void ImprimirHTML(this Impressora impressora)
        {
            System.Console.WriteLine($"<html>\r\n  <body>\r\n    {impressora.Impressao}\r\n  </body>\r\n</html>");
        }

    }

}
