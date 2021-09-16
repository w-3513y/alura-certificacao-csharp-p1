namespace certificacao_csharp_roteiro.Aula_1___tipos_de_valor._1___Tipos_de_Valor._2___Tipos_Inteiros
{
    class TiposInteiros : IAulaItem
    {       
        public void Executar()
        {
            char valueChar = char.MaxValue; //System.Char
            byte valueByte = byte.MaxValue; //System.Byte
            sbyte valueSbyte = sbyte.MaxValue; //System.Sbyte -- suporta negativos
            short valueShort = short.MaxValue; //System.Int16
            ushort valueUshort = ushort.MaxValue; //System.UInt16 - não suporta negativos
            int valueInt = int.MaxValue;   //System.Int32
            uint valueUint = uint.MaxValue; //System.Uint32 - não suporta negativos
            long valueLong = long.MaxValue; //System.Int64
            ulong valueUlong = ulong.MaxValue; //System.UInt64 - não suporta negativos
            System.Console.WriteLine("Max Value char: "+ valueChar);
            System.Console.WriteLine("Max Value byte: "+ valueByte);
            System.Console.WriteLine("Max Value sbyte: "+ valueSbyte);
            System.Console.WriteLine("Max Value short: "+ valueShort);
            System.Console.WriteLine("Max Value ushort: "+ valueUshort);
            System.Console.WriteLine("Max Value int: "+ valueInt);
            System.Console.WriteLine("Max Value uint: "+ valueUint);
            System.Console.WriteLine("Max Value long: "+ valueLong);
            System.Console.WriteLine("Max Value ulong: "+ valueUlong);            
            valueChar = char.MinValue;
            valueByte = byte.MinValue;
            valueSbyte = sbyte.MinValue;
            valueShort = short.MinValue;
            valueUshort = ushort.MinValue;
            valueInt = int.MinValue;
            valueUint = uint.MinValue;
            valueLong = long.MinValue;
            valueUlong = ulong.MinValue;
            System.Console.WriteLine("Min Value char: " + valueChar);
            System.Console.WriteLine("Min Value byte: " + valueByte);
            System.Console.WriteLine("Min Value sbyte: " + valueSbyte);
            System.Console.WriteLine("Min Value short: " + valueShort);
            System.Console.WriteLine("Min Value ushort: " + valueUshort);
            System.Console.WriteLine("Min Value int: " + valueInt);
            System.Console.WriteLine("Min Value uint: " + valueUint);
            System.Console.WriteLine("Min Value long: " + valueLong);
            System.Console.WriteLine("Min Value ulong: " + valueUlong);
        }
    }
}
