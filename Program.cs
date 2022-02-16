using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperChat

{
    public class Program
    {
       
        public  static void Main(string[] args)
        {
            Server s1 = new Server();
            Client c1 = new Client();
           



            Console.WriteLine("Registered User? Click 1 \nNew User? Click 2 For Registeration");
           int cw= Convert.ToInt32(Console.ReadLine());
            if (cw == 2)
            {
                Console.WriteLine("Welcome To SuperChat!");
                Console.WriteLine("Hi, Start Your Registeration Process");
                Console.WriteLine("Enter your Name:");
                String a = Console.ReadLine();
                Console.WriteLine("Enter your Mobile Number:");
                long b = Convert.ToInt64(Console.ReadLine());



               Console.WriteLine( c1.Clientregisteration(a, b, s1));
            }
            LoginDetails();
            void LoginDetails()
            {
                Console.WriteLine("Please enter your Name:");
                string q = Console.ReadLine();
                Console.WriteLine("Please enter your Mobile Number:");

                string m = Console.ReadLine();
                long h = Convert.ToInt64(m);
            
                if(s1.CheckUser(h, q) == true)
                {
                    Console.WriteLine("Validation Completed, Login sucessfull!  Continue Your Process");
                    Options(h, q);
                }
                else
                {
                    Console.WriteLine("Login Failed! Please Check your entered Username or Mobilenumber.");
                    Console.ReadKey();
                }
            }
            void Options(long h,string q) {
                

                Console.WriteLine("1. Add a contact to your friend list");
                Console.WriteLine("2. View your friend list");
                Console.WriteLine("3. Remove from your friend list");
                Console.WriteLine("4. Edit Your Profile");
                Console.WriteLine("5. Chat with your Fiend");
                

                Console.WriteLine();
                string l = Console.ReadLine();
                int w = Convert.ToInt32(l);

                switch (w)
                {

                    case 1:
                        Console.WriteLine(c1.Add_Friend(h, s1));
                        Options( h,q);
                        break;
                    case 2:
                        Console.WriteLine("Your Friend List:");
                        Console.WriteLine(c1.View_Friend(h));
                        Options(h,q);
                        break;
                    case 3:
                        Console.WriteLine("Enter the Name you want to Remove");
                       Console.WriteLine(c1.View_Friend(h));
                        string j = Console.ReadLine();
                        Console.WriteLine(c1.Remove_Friend(j,s1));
                        Options( h,q);
                        break;
                    case 4:
                        Console.WriteLine("Choose an option:");
                        Console.WriteLine("1. Edit your Name");
                        Console.WriteLine("2. Edit your Mobile Number");
                        int num = Convert.ToInt32(Console.ReadLine());
                        if (num == 1)
                        {
                            Console.WriteLine("Enter the Name to be Changed");
                            string name = Console.ReadLine();
                            Console.WriteLine(s1.EditYourName(q,name));
                        }
                        else
                        {
                            Console.WriteLine("Enter the Mobile Number to be Changed");
                             long num1 = Convert.ToInt64(Console.ReadLine());
                           Console.WriteLine(s1.EditYourNumber(h, num1));
                        }
                        Options(h, q);
                        break;
                    case 5:
                        c1.Chat(h, q,s1);
                        break;
                   

                    default:
                        Console.WriteLine("Select a Correct Feature!");
                        Options( h,q);
                        break;


                }
            }
            


        }



    }


}

