using System;

namespace JaesaCodePog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Age");
            string ageStr = Console.ReadLine();

            int age = int.Parse(ageStr);

            if(age >= 16){
                Console.WriteLine("You may Enter");

                Console.WriteLine("Please enter your test result out of 100");
                string resultStr = Console.ReadLine();

                int result = int.Parse(resultStr);

                if(result >=80){
                    Console.WriteLine("enjoy ur license bruv happy trails");
                }
                else{
                    Console.WriteLine("sorry bruv ur too bad ta be on tha road");
                }
            }
            else{
                Console.WriteLine("too young, begone child");
            }
            
        }
    }
}
