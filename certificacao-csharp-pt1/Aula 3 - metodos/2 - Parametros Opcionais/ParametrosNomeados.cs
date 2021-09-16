namespace certificacao_csharp_roteiro.Aula_3___metodos._2___Parametros_Opcionais
{
    class ParametrosNomeados : IAulaItem
    {
        public void Executar()
        {
            ImprimirDetalhesDoPedido("João", 1, "Mouse");
            //argumentos nomeados
            ImprimirDetalhesDoPedido(numeroPedido: 2, vendedor: "Carlos", nomeProduto: "Teclado");
            //se for ordenado é possível variar entre argumento variado e posicional
            ImprimirDetalhesDoPedido(vendedor: "João", 2, "Teclado");

        }

        void ImprimirDetalhesDoPedido(string vendedor, int numeroPedido, string nomeProduto)
        {
            if (string.IsNullOrWhiteSpace(vendedor))
            {
                throw new System.ArgumentException(message: "Nome do vendedor não informado");
            }
            System.Console.WriteLine($"vendedor: {vendedor}, Pedido No.: {numeroPedido}, Produto: {nomeProduto}");
        }
    }
}
