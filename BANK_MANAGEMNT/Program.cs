using System;
namespace bank_management
{
    class login_acount
    {

    }





    class Bank_MAnagement
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\tWELL COME TO BANK OF ISLAMIC");
            Console.WriteLine("enter 1 to login to your acount or create a new one or simply preass any key to stop the program ");
            int input=Convert.ToInt32(Console.ReadLine());
           
            if ( input != 1)
            {
                Console.WriteLine("Program stopped.");
                return;
            }
            while (input == 1)
            {
                Console.WriteLine("          You have chosen to login or create a new account.");
                
                Console.WriteLine("Enter 1 to login to your account 2 create a new one, or simply press any other key to stop the program:");
                 input = Convert.ToInt32(Console.ReadLine());
                if (input != 1 && input !=2)

                {
                    Console.WriteLine("Program stopped.");
                    return;
                }
                //log acount 
               else if (input == 1)
                {
                    Console.WriteLine("log in ");
                }
                //creat account 
               else if (input == 2)
                {
                    Console.WriteLine("creat acount ");
                }




            }


        }
        
    }
}
