using System;
namespace netx;


public class HandlingException
{

    public HandlingException()
    {
        
    }
    public void catchingWithFilter()
    {
        Console.Write("Enter an amount: ");
        string amount = Console.ReadLine() ?? "";
        if (string.IsNullOrEmpty(amount)) return;

        try
        {
            decimal amountValue = decimal.Parse(amount);
            if(amountValue < 0)
            {
                Console.WriteLine("Amount must be positive");
                return;
            }

            Console.WriteLine($"Amount formatted as currency: {amountValue:C}");
        }
        catch (FormatException) when (amount.Contains("$"))
        {
            Console.WriteLine("Amounts cannot use the dollar sign!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Amounts must only contain digits!");
        }
        
    }

}
