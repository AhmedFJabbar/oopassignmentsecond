using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3assigmentsecond
{
    class Account
    {
        public string username;
        public string password;
        public Account(string username,string password)
        {
            this.username = username;
            this.password = password;
        }
        public Account(Account account)
        {
            this.username = account.username;
            this.password = account.password;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
     
            ArrayList accountlist = new ArrayList();
            Console.WriteLine("Enter the number of the accounts you want to add :");
            int  n =Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Infotmation of account number {i+1} :");
                Console.WriteLine("Enter the username :");
                string username=Console.ReadLine();
                Console.WriteLine("Enter the password : ");
                string password=Console.ReadLine();
                Account account = new Account(username, password);
                Account accountcopy = new Account(account);
                accountlist.Add(accountcopy);
            }
            Console.WriteLine("------------------------------");

            Console.WriteLine("Enter the username :");
            string username1 = Console.ReadLine();
            Console.WriteLine("Enter the password : ");
            string password1 = Console.ReadLine();
            Account account2 = new Account(username1, password1);
            bool t = false;
            for (int i = 0; i < n; i++)
            {
                Account account = (Account)accountlist[i];
                if (account.username == account2.username && account.password == account2.password)
                {
                    Console.WriteLine("correct credentials :");
                    t = true;
                    break;
                }
            }
            if(t==false)
                Console.WriteLine("invalid credentials :");
            Console.ReadLine();
        
        
        }  
    }
}
