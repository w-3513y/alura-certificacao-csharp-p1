namespace certificacao_csharp_roteiro.Aula_5___box._1___Boxing
{
    class Boxing : IAulaItem
    {
        public void Executar()
        {
            //de uma variável do tipo valor para uma do tipo referência
            int numero = 57;
            object caixa = numero; //boxing
            System.Console.WriteLine(caixa); 
            System.Console.WriteLine(string.Concat("resposta", numero, true)); //boxing
        }
    }
}
