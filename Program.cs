using System;
using System.Linq;
using System.Collections;
using System.Runtime.InteropServices;
using System.Net.Security;
using System.Security.Authentication;
public class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("********************Harsha Bank*************************");
        System.Console.WriteLine("::Login Page::");


        //declare variables to store username  and password;
        string userName, password = null;

        //read username from keyboard 
        System.Console.WriteLine("UserName: ");
        userName = Console.ReadLine();

        //read password from keyboard if username is entered
        if (userName != "")
        {
            System.Console.WriteLine("Password:");
            password = System.Console.ReadLine();
        }

        //check username and password
        if (userName == "system" && password == "manager")
        {
            //declare variable to store menu choice
            int mainMenuChoice = -1;
            do
            {
                System.Console.WriteLine("\n::: Main Menu");
                System.Console.WriteLine("1: Customers");
                System.Console.WriteLine("2: Accounts");
                System.Console.WriteLine("3: Funds Transfer");
                System.Console.WriteLine("4: Funds Transfer Statement");
                System.Console.WriteLine("5: Account Statement");
                System.Console.WriteLine("0: Exit");

                System.Console.WriteLine("Enter choice: ");
                mainMenuChoice = int.Parse(Console.ReadLine());

                //switch case to check menu choice
                switch (mainMenuChoice)
                {
                    case 1:
                        CustomersMenu();//to do display customer menu
                        break;
                    case 2:
                        AccountsMenu();//to do display accounts menu
                        break;
                    case 3://to do display funds transfer menu
                        break;
                    case 4://to do display funds transfer statement menu
                        break;
                    case 5://to do display account statement menu
                        break;

                }
            } while (mainMenuChoice != 0);
        }
        else
        {
            System.Console.WriteLine("Invalid username or password");
        }

        //about to exit
        System.Console.WriteLine("Thank you! visit again.");
        Console.ReadKey();

    }
    static void CustomersMenu()
    {
        //variable to store customers menu choice
        int customerMenuChoice = -1;

        //do-while loop starts
        do
        {
            //print customers
            System.Console.WriteLine("\n::: Customers menu:::");
            System.Console.WriteLine("1. Add customer");
            System.Console.WriteLine("2. Delete customer");
            System.Console.WriteLine("3. Update customer");
            System.Console.WriteLine("4. View customer");
            System.Console.WriteLine("0. Back to main menu");

            //acccept customers menu choice
            System.Console.WriteLine("Enter choice:");
            customerMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());
        } while (customerMenuChoice != 0);
    }
    static void AccountsMenu()
    {
        //variable to store customers menu choice
        int accountsMenuChoice = -1;

        //do-while loop starts
        do
        {
            //print customers
            System.Console.WriteLine("\n::: Accounts menu:::");
            System.Console.WriteLine("1. Add aacount");
            System.Console.WriteLine("2. Delete account");
            System.Console.WriteLine("3. Update account");
            System.Console.WriteLine("4. View account");
            System.Console.WriteLine("0. Back to main menu");

            //acccept customers menu choice
            System.Console.WriteLine("Enter choice:");
            accountsMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());
        } while (accountsMenuChoice != 0);
    }

}
