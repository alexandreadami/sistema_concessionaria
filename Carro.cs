using System;
using NetOffice.ExcelApi;


public class Carro{
    
    public string marca { get; set; }
    public string modelo { get; set; }
    public string ano { get; set; }
    public int preco { get; set; }
    
    public void CapturarDados(){
        Console.Write("Informe a marca : ");
        marca = Console.ReadLine();
        
        Console.Write("Infome o modelo: ");
        modelo = Console.ReadLine();
        
        Console.Write("Informe o ano: ");
        ano = Console.ReadLine();

        Console.Write("Informe o valor: ");
        preco = int.Parse(Console.ReadLine());
    }
    



 }
        