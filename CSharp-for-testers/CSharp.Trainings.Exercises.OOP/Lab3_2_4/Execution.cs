namespace CSharp.Trainings.Exercises.OOP.Lab3_2_4;

public class Execution
{
    public static void Execute()
    {
        Console.WriteLine($"Exercices LAB3_2_4");
        Console.WriteLine("");

        // zad 1
        var myCard = new CreditCard();
        myCard.Deposit(1234, 200m);
        myCard.Deposit(1235, 300m);

        // zad 2
        decimal fee = myCard.Pay(1234, 100m);
        Console.WriteLine($"Fee correct PIN: {fee}");

        fee = myCard.Pay(1235, 50m);
        Console.WriteLine($"Fee incorrect PIN: {fee}");

        // zad 3
        fee = myCard.PayModified(1234, 10);
        Console.WriteLine($"Fee correct PIN: {fee}");

        fee = myCard.PayModified(1234, 40);
        Console.WriteLine($"Fee correct PIN but not enough money: {fee}");

        fee = myCard.PayModified(1235, 50m);
        Console.WriteLine($"Fee incorrect PIN: {fee}");

        Console.WriteLine("");
    }
}
