using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperChat
{
    public class Client
    {
        
        #region fields

        public string Name { get; set; }
        public long MobileNumber { get; set; }
        #endregion
        List<Client> FriendList = new List<Client>();

        #region public methods
        public Client()
        {

        }
       public string Clientregisteration(String name, long mbl_number, Server s)
        {
            s.RegisteredClients.Add(new Client { Name = name, MobileNumber = mbl_number });
            s.RegisteredClients.Add(new Client { Name = "Ravi", MobileNumber = 9834556789 });
            s.RegisteredClients.Add(new Client { Name = "Murali", MobileNumber = 9834556789 });


            return "Registartion completed sucessfull";
        }
        public string Add_Friend(long mbl_number,  Server s)
        {
            Console.WriteLine("Enter Your Friend's Name to be Added");

            Console.WriteLine(s.UsersList());
             string name1 = Console.ReadLine();

            if (s.Available(name1) == true)
            {


                return FriendsList(name1, mbl_number,s);

            }
            else
            {
                return "Enter a Valid Friend Name";
            }

        }

        public string FriendsList(string name, long mbl_number, Server s)
        {

            int index = s.Index(name);

            FriendList.Add(s.RegisteredClients[index]);

            return "Friends Added Successfully";
        }

        public string View_Friend(long v)
        {
            string t = "";
            string friends = "";

            int cnt = 0;

            foreach (Client s1 in FriendList)
            {
                cnt++;
                t = cnt + "." + s1.Name+ " " + s1.MobileNumber + " ";
                friends += "\n"+t;


            }
           return friends;
        }

        public string Remove_Friend(string name, Server s)
        {
            int h = s.Index(name);
                if (h == -1)
                {
                   
                return "Incorrect Friend Name";
            }
            else
            {
                FriendList.Remove(s.RegisteredClients[h]);
                return "Contact Deletion Done";
            }
            
           
        }
        public void Chat(long num,string q,Server n)
        {
            Console.WriteLine("Enter the Friend's name you want to message");
            Console.WriteLine(View_Friend(num));
            string nme1 = Console.ReadLine();
            Console.WriteLine("Message:");
            string message = Console.ReadLine();
            string mess=n.Message(q, nme1, message);
            Console.WriteLine( nme1 +" "+"Message Alert");
        
           Console.WriteLine( mess);
            Console.WriteLine("click any key to reply");

            Console.ReadKey();
            ReplyMessage(q, nme1, n);
            
        }
     
        public void ReplyMessage( string q, string name1,Server n)
        {
            Console.WriteLine("Reply Message:");
            string message = Console.ReadLine();
            string mess=n.Message(name1, q, message);
            Console.WriteLine(q +" "+"Message Alert");
            Console.WriteLine(mess);
            Console.WriteLine("Click any key to reply");
            Console.ReadKey();
           
        }


    }
    #endregion
}