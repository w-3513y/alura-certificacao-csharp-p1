namespace certificacao_csharp_roteiro.Aula_6___Cast._4___Metodos_Auxiliares_de_Conversao
{
    class MetodosAuxiliares : IAulaItem
    {
        public void Executar()
        {
            string textoDigitado = "123";           
            int numeroConvertido = int.Parse(textoDigitado);
            System.Console.WriteLine(numeroConvertido);

            textoDigitado = "ABC";
            if (int.TryParse(textoDigitado, out numeroConvertido))
            {
                System.Console.WriteLine(numeroConvertido);
            }

            textoDigitado = "123,45";
            decimal.TryParse(textoDigitado, 
                System.Globalization.NumberStyles.Currency, //moeda
                System.Globalization.CultureInfo.CurrentCulture, //pt-br
                out decimal decimalConvertido);
            System.Console.WriteLine(decimalConvertido);
        }
    }
}
