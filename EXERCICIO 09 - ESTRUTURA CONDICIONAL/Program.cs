using System;
namespace EXERCICIO_09___ESTRUTURA_CONDICIONAL{
    class Program{     
        /// -------> START / MAIN 
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args){
            Msg();
            Conditional();
        }
        /// -------> FUNCTIONS
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Msg(){
            Console.WriteLine("DETERMINE A QUANTIDADE DE IMPOSTO DEVIDA.");
        }
        //------------------------------------------------------------------------------------------//
        static void Conditional(){
            double income, tax;
            Console.Write("DIGITE O RENDIMENTO: ");
            income = int.Parse(Console.ReadLine());
            
            if (income >= 2000.01 && income <= 3000){
                Console.WriteLine("8% de imposto");
                tax = 0.08 * income;
                Console.WriteLine("IMPOSTO DEVIDO: " + tax);
            }
            else if (income > 3000.01 && income < 4500){
                Console.WriteLine("18% de imposto");
                tax = 0.18 * income;
                Console.WriteLine("IMPOSTO DEVIDO: " + tax);
            }
            else if (income > 4500){
                Console.WriteLine("28% de imposto");
                tax = 0.28 * income;
                Console.WriteLine("IMPOSTO DEVIDO: " + tax);
            }
            else{
                Console.WriteLine("ISENTO DE IMPOSTO");
            }      
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        /// -------> END
    }
}
