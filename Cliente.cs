using System;


public class Cliente{
    
    public string nome { get; set; }
    public string cpf { get; set; }
    
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
                //Console.WriteLine("cpf valido");
                //Console.ReadKey();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Cpf invalido");
            }

            
        } while (!cpfvalido);
        
        
        
        
        
        
    }
    
    


 }
        

        
        


    
    
