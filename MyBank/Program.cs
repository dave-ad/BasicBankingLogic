// See https://aka.ms/new-console-template for more information
using MyBank;

try
{
    int balance = 0;
    string name = "";

    //var account = new BankAccount("David", 10000);
    Console.WriteLine("Input your full name");
    name = Console.ReadLine();

    bool repeat = false;

    do {
        repeat = false;

        try
        {
            Console.WriteLine("Input your intial deposit");
            // tryparse
            balance = Convert.ToInt32(Console.ReadLine());




            Console.WriteLine("Input your full name and intial deposit");
            //Console.WriteLine($"Account {account.Number} was created for {account.Owner} with ${account.Balance}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            repeat = true;
        }

    } while(repeat);


    Console.ReadKey();

    var account = new BankAccount(name, balance);

    Console.WriteLine("Input the price of your item and a note");
    account.MakeWithdrawal(Convert.ToInt32(Console.ReadLine()), DateTime.Now, Console.ReadLine());
    //Console.WriteLine(account.Balance);

    Console.WriteLine("Input the price of your Item and a note");
    account.MakeWithdrawal(Convert.ToInt32(Console.ReadLine()), DateTime.Now, Console.ReadLine());
    //Console.WriteLine(account.Balance);



    Console.WriteLine("-----Your Recipt-----");
    Console.WriteLine(account.GetAccountHistory());

    //Test for a negative balance.
    try
    {
        account.MakeWithdrawal(75000, DateTime.Now, "Attempt to overdraw");
    }
    catch (InvalidOperationException e)
    {
        Console.WriteLine("Exception caught trying to overdraw");
        Console.WriteLine(e.ToString());
    }

} catch(Exception ex) {
    Console.WriteLine(ex.Message);
}



//Test that the initial balance must be positive.
try
{
    var invalidAccount = new BankAccount("invalid", -55);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("Exception caught creating account with negative balance");
    Console.WriteLine(e.ToString());
}