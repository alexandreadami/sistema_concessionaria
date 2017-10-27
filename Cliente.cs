using System;
using NetOffice.ExcelApi;


public class Cliente{
    
    public string nome { get; set; }
    public string cpf { get; set; }

    public string endereco { get; set; }
    
    public void CapturarDados(){
        Console.Write("Informe seu nome: ");
        nome = Console.ReadLine();
        bool cpfvalido = false;
        Validacao validadocumento = new Validacao();
        
        do
        {
            Console.Write("Infome seu CPF: ");
            cpf = Console.ReadLine();
            cpfvalido = validadocumento.ValidarCPF(cpf);

            if (cpfvalido)
            {
                Console.WriteLine();
                Console.WriteLine("CPF valido.");
                Console.WriteLine("Tecle <ENTER> para continuar");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("CPF invalido!");
                Console.WriteLine("Informe um CPF válido!");
                Console.WriteLine();
            }

            
        } while (!cpfvalido);
        
        
        Console.WriteLine();
        Console.Write("Informe seu endereço: ");
        endereco = Console.ReadLine();


        
        
        
    }
    
    


 }
        

        
        


    
    
