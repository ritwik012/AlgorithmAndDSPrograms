using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDSPrograms
{
    public class BankingCashCounter
    {
        public void CashCounter()
        {
            Queue<string> list = new Queue<string>();
            Console.WriteLine("Enter the number of people in Queue");
            int number = Convert.ToInt32(Console.ReadLine());
            string[] names = new string[number];
            double[] account = new double[number];
            Console.WriteLine("Enter Names Of People and their account balance : ");
            for (int i = 0; i < number; i++)
            {
                names[i] = Console.ReadLine();
                account[i] = Convert.ToDouble(Console.ReadLine());
                list.Enqueue(names[i]);
            }
            for (int j = 0; j < names.Length; j++)
            {
                Console.WriteLine("Customer : {0} \t Account Balance : {1}", names[j], account[j]);
                Console.WriteLine("Select Option : \n 1. Deposit \n 2. Withdrawl \n 3. Available Balance");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter The Amount To Deposit : ");
                        double deposit = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Amount Deposited is " + deposit);
                        account[j] += deposit;
                        Console.WriteLine("Total Balance = " + account[j]);
                        list.Dequeue();
                        break;
                    case 2:
                        Console.WriteLine("Enter The Amount To Withdraw : ");
                        double withdrawl = Convert.ToDouble(Console.ReadLine());
                        if (withdrawl <= 20000 && account[j] > 0)
                        {
                            if (withdrawl <= account[j])
                            {
                                Console.WriteLine("Amount Withdrawn is : " + withdrawl);
                                account[j] -= withdrawl;
                                Console.WriteLine("Total Balance = " + account[j]);
                                list.Dequeue();
                            }
                            else
                            {
                                Console.WriteLine("$$$$ You have insufficient amount in your account to withdraw $$$$");
                            }
                        }
                        else
                        {
                            Console.WriteLine("The Withdrawl limit is 20000 per transaction ..... Please Enter accordingly .....");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Your Account balance is : " + account[j]);
                        break;
                    default:
                        Console.WriteLine("Enter Correct Option");
                        break;
                }
            }
        }
    }
}