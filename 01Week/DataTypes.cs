using System;



class DataTypes
{
    public static void Main()
    {
        //bool isHuman = true;
        //bool f = false;
        decimal num = 9.99m;
        decimal total = num * num;
        string firstName = "Jamie";
        string lastName = "Fox";
        int age = 51;
        string job = "Teacher";
        string favoriteBand = "Maroon 5";
        string favoriteSportsTeam = "Spurs";


        Console.WriteLine("First Name: " + firstName);
        Console.WriteLine("Last Name: " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("job: " + job);
        Console.WriteLine("Favorite Band: " + favoriteBand);
        Console.WriteLine("Favorite Sports Team: " + favoriteSportsTeam);
        Console.ReadLine();


        int myInteger = (int)num;
        Console.WriteLine("My Integer: " + myInteger);
        Console.ReadLine();
    }

    /*public override bool Equals(object obj)
     {
         return base.Equals(obj);
     }

     public override int GetHashCode()
     {
         return base.GetHashCode();
     }

     public override string ToString()
     {
         return base.ToString();*/

}
