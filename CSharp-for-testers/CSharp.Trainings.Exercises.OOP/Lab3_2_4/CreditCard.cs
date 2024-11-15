namespace CSharp.Trainings.Exercises.OOP.Lab3_2_4;

public class CreditCard
{
    decimal _balance;
    int _pin = 1234;
    decimal fee = 0.45m;

    public bool ValidatePin(int pin)
    {
        return _pin == pin;

        /* alternatywnie
          
        bool areEqual = _pin == pin;
        return areEqual;         
         
         */
    }

    public void Deposit(int pin, decimal amount)
    {
        bool isPinValid = ValidatePin(pin);

        if (isPinValid)
        {
            Console.WriteLine($"Depositing {amount} dollars into your bank account.");
            _balance += amount;
        }
        else
        {
            Console.WriteLine($"Provided pin is wrong.");
        }
    }

    public decimal Pay(int pin, decimal amount)
    {
        bool isPinValid = ValidatePin(pin);

        if (isPinValid)
        {
            Console.WriteLine($"Paying {amount} dollars.");
            _balance = _balance - amount - fee;
            return fee;
        }
        else
        {
            Console.WriteLine($"Provided pin is wrong.");
            return 0m; // nie nie zapłaciliśmy to nie było też prowizji
        }
    }

    public decimal PayModified(int pin, decimal amount)
    {
        bool isPinValid = ValidatePin(pin);

        if (isPinValid)
        {
            decimal amountWithFee = amount + fee;

            if (amountWithFee > _balance)
            {
                Console.WriteLine($"Paying {amount} dollars.");
                return fee;
            }
            else
            {
                Console.WriteLine($"Sorry, not enough money to pay {amountWithFee}");
                return 0m;
            }
        }
        else
        {
            Console.WriteLine($"Provided pin is wrong.");
            return 0m; // nie nie zapłaciliśmy to nie było też prowizji
        }
    }
}