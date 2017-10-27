using System;

namespace sistema_concessionaria
{
    class Program
    {
        static void Main(string[] args)
        {
           



             string opcao = "0";
            do{
                Console.Clear();
                Console.WriteLine("==========================");
                Console.WriteLine("  SISTEMA CONCESSIONÁRIA  ");

                Console.WriteLine();
                Console.WriteLine("    Digite a opção:");
                Console.WriteLine();
                Console.WriteLine("    1 - Cadastrar Cliente");
                Console.WriteLine("    2 - Cadastrar Carro");
                Console.WriteLine("    3 - Vender Carro");
                Console.WriteLine("    4 - Listar Carros Vendidos");
                Console.WriteLine("    5 - Sair");
                Console.WriteLine();
                Console.WriteLine("===========================");
                
                //Recebe opção do Operador
                Console.WriteLine();
                Console.Write("Opção: ");
                opcao = Console.ReadLine();


                switch (opcao)
                {
                    case "1":
                        //Cadastro do cliente
                        Console.Clear();
                        Cliente cliente = new Cliente();
                        cliente.CapturarDados();
                        break;
                    case "2":
                        //Casdastro do carro
                        Console.Clear();
                        Carro carro = new Carro();
                        carro.CapturarDados();
                        break;
                    case "3":
                        //Venda do Carro
                        Console.Clear();
                        
                        break;
                    case "4":
                        Console.Clear();
                        //ListaCarrosVendidos();
                        break;            
                    //default:
                }


            }while(opcao != "5");













        }
    }
}
