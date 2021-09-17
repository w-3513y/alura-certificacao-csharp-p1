using certificacao_csharp_roteiro.Aula_1___tipos_de_valor._1___Tipos_de_Valor._1___Tipos_de_Valor;
using certificacao_csharp_roteiro.Aula_1___tipos_de_valor._1___Tipos_de_Valor._2___Tipos_Inteiros;
using certificacao_csharp_roteiro.Aula_1___tipos_de_valor._1___Tipos_de_Valor._3___Tipos_de_Ponto_Flutuante;
using certificacao_csharp_roteiro.Aula_1___tipos_de_valor._1___Tipos_de_Valor._4___Decimal;
using certificacao_csharp_roteiro.Aula_1___tipos_de_valor._1___Tipos_de_Valor._5___Booleans;
using certificacao_csharp_roteiro.Aula_1___tipos_de_valor._1___Tipos_de_Valor._6___Structs;
using certificacao_csharp_roteiro.Aula_1___tipos_de_valor._1___Tipos_de_Valor._7___Enums;
using certificacao_csharp_roteiro.Aula_2___tipos_de_referencia._1___Tipos_de_Referencia;
using certificacao_csharp_roteiro.Aula_2___tipos_de_referencia._2___Classes;
using certificacao_csharp_roteiro.Aula_2___tipos_de_referencia._3___Interfaces;
using certificacao_csharp_roteiro.Aula_2___tipos_de_referencia._4___Delegates;
using certificacao_csharp_roteiro.Aula_2___tipos_de_referencia._5___Objetos;
using certificacao_csharp_roteiro.Aula_2___tipos_de_referencia._6__Dynamic;
using certificacao_csharp_roteiro.Aula_2___tipos_de_referencia._7___Strings;
using certificacao_csharp_roteiro.Aula_3___metodos._1___Metodos;
using certificacao_csharp_roteiro.Aula_3___metodos._2___Parametros_Opcionais;
using certificacao_csharp_roteiro.Aula_3___metodos._3___Metodos_de_Extensão;
using certificacao_csharp_roteiro.Aula_3___metodos._4___Propriedades_Indexadas;
using certificacao_csharp_roteiro.Aula_4___sobrecargas._1___Metodos_Sobrecarregados;
using certificacao_csharp_roteiro.Aula_4___sobrecargas._2___Metodos_Substituidos;
using certificacao_csharp_roteiro.Aula_5___box._1___Boxing;
using certificacao_csharp_roteiro.Aula_6___Cast;
using certificacao_csharp_roteiro.Aula_6___Cast._2___Operadores;
using certificacao_csharp_roteiro.Aula_6___Cast._3___Conversoes_definidas;
using certificacao_csharp_roteiro.Aula_6___Cast._4___Metodos_Auxiliares_de_Conversao;
using certificacao_csharp_roteiro.Aula_7___Tipos_Dinamicos._1___Usando_Dynamics;
using certificacao_csharp_roteiro.Aula_7___Tipos_Dinamicos._2___Convertendo_Dynamics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Program
    {
        static IList<MenuItem> menuItems;
        static void Main(string[] args)
        {
            IAulaItem itemSelecionado;
            menuItems = GetMenuItems();

            while (true)
            {
                ImprimirMenuItems(menuItems);
                var opcao = Console.ReadLine();

                int.TryParse(opcao, out int valorOpcao);

                if (valorOpcao == 0)
                {
                    break;
                }

                if (valorOpcao > menuItems.Count)
                {
                    break;
                }

                itemSelecionado = Executar(valorOpcao);
                Console.ReadKey();
            }
        }

        private static IAulaItem Executar(int valorOpcao)
        {
            IAulaItem itemSelecionado;
            MenuItem menuItem = menuItems[valorOpcao - 1];
            Type tipoClasse = menuItem.TipoClasse;
            itemSelecionado = (IAulaItem)Activator.CreateInstance(tipoClasse);

            Console.WriteLine();
            string titulo = $"EXECUTANDO: {menuItem.Titulo}";
            Console.WriteLine(titulo);
            Console.WriteLine(new string('=', titulo.Length));

            itemSelecionado.Executar();
            Console.WriteLine();
            Console.WriteLine("Tecle algo para continuar...");
            return itemSelecionado;
        }

        private static void ImprimirMenuItems(IList<MenuItem> menuItems)
        {
            int i = 1;
            Console.WriteLine("SELECIONE UMA OPÇÃO");
            Console.WriteLine("===================");
            Console.WriteLine("0 - Sair");
            foreach (var menuItem in menuItems)
            {
                Console.WriteLine((i++).ToString() + " - " + menuItem.Titulo);
            }
        }

        private static IList<MenuItem> GetMenuItems()
        {
            return new List<MenuItem>
            {
                new MenuItem("Tipos de Valor", typeof(TiposDeValor)),
                new MenuItem("Tipos Inteiros", typeof(TiposInteiros)),
                new MenuItem("Ponto Flututante", typeof(PontoFlutuante)),
                new MenuItem("Decimal", typeof(Decimais)),
                new MenuItem("Booleanos", typeof(Booleans)),
                new MenuItem("Estruturas", typeof(Structs)),
                new MenuItem("Enumeracoes", typeof(Enums)),
                new MenuItem("Tipos de Refêrencia", typeof(TiposDeReferencia)),
                new MenuItem("Classes", typeof(Classes)),
                new MenuItem("Interfaces", typeof(Interfaces)),
                new MenuItem("Delegates", typeof(Delegates)),
                new MenuItem("Objetos", typeof(Objetos)),
                new MenuItem("Dinâmicos", typeof(Dinamicos)),
                new MenuItem("Strings", typeof(Strings)),
                new MenuItem("Metodos", typeof(Metodos)),
                new MenuItem("Parâmetros Nomeados", typeof(ParametrosNomeados)),
                new MenuItem("Parâmetros Opcionais", typeof(ParametrosOpcionais)),
                new MenuItem("Métodos de Extensão", typeof(MetodosDeExtensao)),
                new MenuItem("Propriedades Indexadas", typeof(PropriedadesIndexadas)),
                new MenuItem("Sobrecargas", typeof(Sobrecargas)),
                new MenuItem("Métodos Substituidos", typeof(MetodosSubstituidos)),
                new MenuItem("Boxing", typeof(Boxing)),
                new MenuItem("Unboxing", typeof(Unboxing)),
                new MenuItem("Conversoes Implícitas", typeof(ConversoesImplicitas)),
                new MenuItem("Conversoes Explícitas", typeof(ConversoesExplicitas)),
                new MenuItem("Operadores IS e AS", typeof(IsAndAs)),
                new MenuItem("Operadores de Conversão", typeof(ConversoesUsandoOperadores)),
                new MenuItem("Métodos Auxiliares de Conversão", typeof(MetodosAuxiliares)),
                new MenuItem("Usando Dynamic", typeof(UsandoDynamic)),
                new MenuItem("Conversões de Dynamic", typeof(ConvertendoDynamic)),
                //new MenuItem("Resolucão de Sobrecarga", typeof(ResolucaoSobrecarga)),
                //new MenuItem("Usando ExpandObject", typeof(UsandoExpandObject)),
                //new MenuItem("Interoperabilidade COM", typeof(InteropCOM))                
            };
        }
    }

    class MenuItem
    {
        public MenuItem(string titulo, Type tipoClasse)
        {
            Titulo = titulo;
            TipoClasse = tipoClasse;
        }

        public string Titulo { get; set; }
        public Type TipoClasse { get; set; }
    }
}
