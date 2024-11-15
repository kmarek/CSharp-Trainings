namespace CSharp.Trainings.Exercises.OOP.Lab3_2_3;

public class Person
{
    public int age;
    public string email;

    public int AddYears(int add)
    {
        int sum = age + add;
        age = sum;
        // albo age += add; 
        // albo age = age + add;
        return age;
    }

    public int GetAge()
    {
        return age;
    }

    public void SetEmail(string email)
    {
        this.email = email;
    }

    public string GetEmail()
    {
        return email;
    }
}
