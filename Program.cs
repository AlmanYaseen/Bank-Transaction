using System;
using System.Runtime.InteropServices;
using System.Collections;


namespace Bank_Transaction

{
    class customer

    {
        public int customerid;
        public string account_no;
        public string Name;
        public string contact;
        public string Email;
        public double balance;








        public customer(int customerid, string Name, string account_no, double balance, string contact, string Email)
        {
            this.customerid = customerid;
            this.Name = Name;
            this.account_no = account_no;
            this.balance = balance;
            this.contact = contact;
            this.Email = Email;
        }

        public void Get_details()

        {
            Console.WriteLine("Enter account number for details:");
            string acc_no = Console.ReadLine();
            if (acc_no == account_no)

            {
                Console.WriteLine("customerid:{0}\n Name:{1}\n account_no:{2}\n balance:{3}\n contact:{4}\n Email:{5}", customerid, Name, account_no, balance, contact, Email);
            }
            else
            {
                Console.WriteLine("Entered wrong account number");
            }
        }

        public void Bal_enquiry()
        {

            Console.WriteLine("Enter account number:");
            string account_number = Console.ReadLine();
            if (account_number == account_no)
            {
                Console.WriteLine("Balnce in the account is :" + balance + "/-");
            }
            else
            {
                Console.WriteLine("Entered wrong account number");
            }
        }

        public void deposit()
        {
            Console.WriteLine("Enter account number:");
            string ac = Console.ReadLine();
            if (ac == account_no)
            {
                Console.WriteLine("enter the amount to deposite:");
                int amt = Convert.ToInt32(Console.ReadLine());
                if (amt > 500)
                {
                    balance = balance + amt;
                }
                else
                {
                    Console.WriteLine("Ammount less than 500 is not accepted");
                }
                Console.WriteLine("balance after deposite:" + balance + "/-");

            }
            else
            {
                Console.WriteLine("Enter wrong account Number");
            }




        }

        public void withdraw()
        {
            Console.WriteLine("Enter the account number:");
            string accno1 = Console.ReadLine();
            if (accno1 == account_no)
            {
                Console.WriteLine("Enter the withdraw ammount:");
                int wammount = Convert.ToInt32(Console.ReadLine());
                if (wammount <= balance && wammount >= 500)
                {
                    balance = balance - wammount;
                    Console.WriteLine("Balnce after withdraw is:" + balance + "-/");
                }
                else
                {
                    Console.WriteLine("Withdraw amount greater/less than balance cannot proceed the request");
                }


            }
            else
            {
                Console.WriteLine(" Entered wrong account number");
            }

        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\t\t***WELCOME TO MY BANK*** ");
            Console.WriteLine("1.HOME\n2.ABOUT US\n3.EXIT");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {




                Console.WriteLine("1.DETAILS OF CUSTOMER\t\t2.ENQUIRY\n3.DEPOSITE\t\t\t4.WITHDRAW ");
                Console.WriteLine("\n\tSELECT THE OPTION FROM ABOVE OPTIONS:");
                int ch = Convert.ToInt32(Console.ReadLine());

                var s = new customer(101, "peter", "100001", 7000, "910049876", "peter184@gmail.com");
                var s1 = new customer(102, "Jack", "100002", 5000, "910045678", "jack124@gmail.com");
                var s2 = new customer(103, "lilly", "100003", 9000, "986864573", "lilly124@gmail.com");



                switch (ch)
                {
                    case 1:
                        s.Get_details();
                        Console.WriteLine("***THANK YOU***");
                        break;
                    case 2:
                        s.Bal_enquiry();
                        Console.WriteLine("***THANK YOU***");

                        break;
                    case 3:
                        s.deposit();
                        Console.WriteLine("***THANK YOU***");

                        break;
                    case 4:
                        s.withdraw();
                        Console.WriteLine("***THANK YOU***");

                        break;
                    default:
                        Console.WriteLine("Entered invalid option");
                        break;

                       
                }      
            }
            else if (num == 2)
            {


                Console.WriteLine(" The Bank Transaction App is build for all kind of transaction such as \n" +
               "Details will show the bank statement\n" +
               "Enquiry will show you all the details of customer\n" +
               "Deposit will allow customer to deposit money\n" +
               "Withdraw allows customer to withdraw the money from account ");
                Console.WriteLine(" ****THANK YOU****");
            }
            else
            {
                Console.WriteLine("\t ****THANK YOU****");
            }


        }
    }
        
    }
