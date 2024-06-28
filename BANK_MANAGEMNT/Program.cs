using System;
namespace bank_management
{
   public  class creat_acount_details_list
    {
        public string Name { get;set;}
        public int ID { get; set; }
        public int MOBILE_NUM { get; set; }
        public string ADRESS { get; set; }
        public string Password  { get; set; }
        
    }
    public class acount_create
    {
        public List<creat_acount_details_list> Bank = new List<creat_acount_details_list>();

        public void acountcreate()
        {

            Console.WriteLine("REQUIRED DETAILS");
            Console.WriteLine("Enter You First And Last Name ");
            var name = Console.ReadLine();
            Console.WriteLine("Enter You Id Card Num ");
            var id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter You Mobile Number");
            var mbnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter You Adress ");
            var adress = Console.ReadLine();

            Bank.Add(new creat_acount_details_list { Name = name ,ID=id,MOBILE_NUM=mbnum,ADRESS=adress});
            foreach (var i in Bank) 
            {
            Console.WriteLine($"{i.Name}\n{i.ADRESS}");
            
            }
        }
       

   
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
            while (input == 1||input==2)
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
               if (input == 1)
                {


                    Console.WriteLine("log in ");


                }
                //creat account 
               else if (input == 2)
                {
                    acount_create acount_Create = new acount_create();
                    acount_Create.acountcreate();
                   

               }
              else
                {
                    Console.WriteLine("Program stopped.");
                    return;
                }




            }


        }
        
    }
}
