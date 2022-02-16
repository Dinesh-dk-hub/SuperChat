using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace SuperChat
{
    public class Server
    {
        
        public List<Client> RegisteredClients = new List<Client>();


        public string UsersList()
        {
            string v = "";
            string users = "";

            int l = 0;

            foreach (Client s in RegisteredClients)
            {
                l++;
                v = l + "." + s.Name + " " + s.MobileNumber + " ";
                users += "\n" +v;


            }

            return users;
        }

        public bool CheckUser(long m, string n)
        {
            foreach (Client cl1 in RegisteredClients)
            {
                if (cl1.Name == n && cl1.MobileNumber == m)
                {
                    return true;
                }
            }
            return false;

        }

        public bool Available(string h)
        {
            foreach(Client j in RegisteredClients)
            {
                if(j.Name==(h))
                {

                    return true;
                }
            }
            return false;
        }


        public int Index(string st1)
        {
            for (int i = 0; i < RegisteredClients.Count; i++)
            {
              
                if (RegisteredClients[i].Name == st1)
                {
                    return i;
                }
            }
            return -1;
        }
        public string EditYourName(string name,string new_name)
        {
            for (int i = 0; i < RegisteredClients.Count; i++)
            {
                if (RegisteredClients[i].Name == name)
                {
                    RegisteredClients[i].Name = new_name;
                    return "Entered Name is Changed Successfully";
                }
                
            }
            
           
                return "Please Try again";
            

        }

        public string EditYourNumber(long g, long p)
        {
            for (int i = 0; i < RegisteredClients.Count; i++)
            {
                if (RegisteredClients[i].MobileNumber == g)
                {
                    RegisteredClients[i].MobileNumber = p;
                    return "Updation of Mobile Number Done Successfully";
                }

            }


            return "Updation failed";


        }
        public string Message(string sender, string receiver, string message)
        {
            int h = Index(receiver);
            if (h == -1)
            {

                return "no friends found";
            }
            else
            {


                string g = ToReciver(sender, receiver, message);

                Console.WriteLine("Message sent sucessfully");
                Console.WriteLine();
                return g;

            }

        }

        public string ToReciver(string sender, string receviver, string message)
        {
            string k = "\n"+sender + ":\n" + message;
            return k;

        }
      

        

    }
} 