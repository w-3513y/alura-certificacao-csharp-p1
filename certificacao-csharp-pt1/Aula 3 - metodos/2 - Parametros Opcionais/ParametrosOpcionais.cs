namespace certificacao_csharp_roteiro.Aula_3___metodos._2___Parametros_Opcionais
{
    class ParametrosOpcionais : IAulaItem
    {
        public void Executar()
        {
            ClienteEspecial clienteespecial = new ClienteEspecial("Lucas");
            clienteespecial.FazerPedido(1, "Rua 3", 3);

            clienteespecial = new ClienteEspecial();

            clienteespecial.FazerPedido(2, "Rua Nova");

            clienteespecial.FazerPedido(3);

            clienteespecial.FazerPedido(4, quantidade: 7);

        }

        class ClienteEspecial
        {
            private readonly string Nome;
            public ClienteEspecial(string nome = "Anonimo")
            {
                Nome = nome;
            }

            public void FazerPedido(int produtoId, string endereco = "Sem Endereco", int quantidade = 1)
            {
                System.Console.WriteLine("Cliente {0}: produtoId {1}, endereco: {2}, quantidade: {3}", Nome, produtoId, endereco, quantidade);
            }
        }
    }
}
