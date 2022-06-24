using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {

    Console.WriteLine("");

    /*
    Console.WriteLine("Hello! Welcome to the bank! What do you wish to do today?\nPlease select an option using the provided key below: \n" 
                      + "A - Create Account \n" 
                      + "B - Load Account \n" 
                      + "C - Withdraw \n" 
                      + "D - Deposit \n" 
                      + "E - Check Balance \n");

    string userChoice = Console.ReadLine();
    Console.WriteLine("");
    */

    List<Account> accountList = new List<Account>();

    //Account ryanAcc = new Account("Ryan", "4444 Way, CA", true);
    //accountList.Add(ryanAcc);

    /*
    if(userChoice == "A") //Create Account
    {
      Console.WriteLine("Okay. To create a new account, please provide the information asked.\nYour name:");
      string userName = Console.ReadLine();
      
      Console.WriteLine("Your address:");
      string userAddress = Console.ReadLine();

      Console.WriteLine("Do you want a Savings or Checking account?");
      string checkOrSave = Console.ReadLine();
      bool isSavings = true;
      bool correct = false;
      while(correct == false)
      {
        if(checkOrSave == "Savings" || checkOrSave == "savings")
        {
          isSavings = true;
          correct = true;
        }
        else if(checkOrSave == "Checking" || checkOrSave == "checking")
        {
          isSavings = false;
          correct = true;
        }
        else
        {
          Console.WriteLine("Answer does not confer to 'savings' or 'checking'. Try again.");
          checkOrSave = Console.ReadLine();
        }
      }

      Account newAccount = new Account(userName, userAddress, isSavings);
      accountList.Add(newAccount);
      Console.WriteLine("\nYour account has been created!");

    }

    else if(userChoice == "B") //Load Account
    {
      Console.WriteLine("Please input the name your account is under");
      string userName = Console.ReadLine();
      bool found = false;

      foreach(Account currentAcc in accountList)
      {
        if(currentAcc.cName == userName)
        {
          Account currentAccount = currentAcc;
          found = true;
          Console.WriteLine("Account has been successfully loaded!");
          break;
        }
      }

      if(found == false)
      {
        Console.WriteLine("No account under that name exists. Rerun the program to try again.");
      }
    }
    
    else if(userChoice == "C") //Withdraw
    {
      Console.WriteLine("Please input how much money you wish to withdraw from your account today. Use only numerical values and decimals where needed.");
      string userWithdraw = Console.ReadLine();
      double userWith = double.Parse(userWithdraw);

      bool check = Account.withdraw(userWith);
      if(check == false)
      {
        Console.WriteLine("Your money failed to withdraw. You entered a value too high compared to your balance.");
      }
      else
      {
        Console.WriteLine("Your money has been withdrawn! Here is your $" + userWith + ".");
      }
    }
    
    else if(userChoice == "D") //Deposit
    {
      Console.WriteLine("Please input how much money you wish to deposit into your account today. Use only numerical values and decimals where needed.");
      string userDeposit = Console.ReadLine();
      double userDep = double.Parse(userDeposit);

      bool check = Account.deposit(userDep);
      if(check == true)
      {
        Console.WriteLine("Your money has been deposited!");
      }
    }
    
    else if(userChoice == "E") //Check Balance
    {
      string reply = Account.getBalance();
      Console.WriteLine(reply);
    }
    
    else
    {
      Console.WriteLine("Not an option. Please rerun the program and choose from the available menu.");
    }

    Console.WriteLine("Thank you for doing business with us today. Have a nice day!");
    */

    Account a = new Account("Sarah W.", "1 Lane", true);
    accountList.Add(a);

    Account b = new Account("William S.", "2 Way", true);
    accountList.Add(b);

    Account c = new Account("Drew H.", "3 Street", false);
    accountList.Add(c);
    
    //Bank teller view all Account holders

    foreach(Account allAcc in accountList)
    {
      string name = allAcc.getName();
      Console.WriteLine(name);
    }
  }
}



class Account
{
  public string cName;
  public string cAddress;
  bool isSavings;
  double cBalance;

  public Account(string n, string a, bool iS /* , double b */ )
  {
    cName = n;
    cAddress = a;
    isSavings = iS;
    cBalance = 0;  //b;
  }

  public void accountInfo()
  {
    Console.WriteLine("Account is Under: " + cName + "\n");
    //Console.WriteLine("Address: " + cAddress + "\n");
  }

  public string getName()
  {
    return cName;
  }

  public void typeOfAccount()
  {
    if(isSavings)
    {
      Console.WriteLine("Your account is for savings. \n");
    }
    else
    {
      Console.WriteLine("Your account is for checking. \n");
    }
  }

  /*
  public static string getBalance()
  {
    return "Your current balance is $" + cBalance + ". \n";
  }

  public static bool deposit(double a)
  {
    cBalance += a;
    return true;
  }

  public static bool withdraw(double s)
  {
    if(s > cBalance)
    {
      return false;
    }
    else
    {
      cBalance -= s;
      return true;
    }
    
  }
*/

}