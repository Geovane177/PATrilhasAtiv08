using System;
using System.Collections.Generic;
using System.Linq;

namespace Atividades
{
	class Program
	 {
		
	static string impar (string palavra){
		string frase = "";

	            for (int i = 0; i < palavra.Length; i += 2)  
	            {
	                frase += palavra[i];  
	            }      
	            return frase;
	}
	
	 public static void Main()
	        {
	 	
	 	Console.WriteLine("Digite uma Frase:");
	    string palavra = Console.ReadLine();
	 	
	    string frase = impar(palavra);
	    
	    Console.WriteLine(frase);

           Console.Write("Pressione para continuar ");
            Console.ReadKey(true);
        }
    }
}
