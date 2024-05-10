//Things in C# are written PascalCase - first letter of the word is capitalized
//Compiles every line of code top to bottom before running if something is broken, it won't run the program
//Public and Private tells your application what can be accessed or not 
//Private is only for the class it is inside
//Main is the entrypoint of the application
using System.Reflection.Metadata;

public class Program
{
  private static string[] FavoriteFoods = ["lasagna", "fettuccine", "pizza", "ram", "tacos el pastor", "bagel bites"];

  //You use lists not arrays because arrays are uneditable
  private static List<Friend> Friends = [
    new Friend("Mick", 20, "pizza"),
    new Friend("Jake", 30, "Noodles"),
    new Friend("Garfield", 40, "lasagna")
  ];


  private static void Main()
  {
    Console.Clear(); //Clears the console before your code is written
    Console.WriteLine("Hello, new friend!");
    Console.WriteLine("What is your name?");

    string userName = Console.ReadLine(); //Reads what the user said || camel Case is used for declaring variables

    Console.WriteLine($"Nice to meet you {userName}! That is a very nice name!"); //Dollar sign goes outside of quotes

    Console.WriteLine($"How old are you {userName}?");

    int userAge = GetUserAge();

    Console.WriteLine($"Dang you are {userAge} years old?");
    Console.WriteLine($"That is crazy my brother is twice as old as you! He is {userAge * 2}");

    Console.WriteLine($"{userName}, what do {userAge} year olds eat nowadays?");

    string userFavoriteFood = Console.ReadLine();

    Console.WriteLine($"Your favorite food is {userFavoriteFood}?");

    if (FavoriteFoods.Contains(userFavoriteFood)) //Compares to the list we created above
    {
      Console.WriteLine($"{userFavoriteFood} is my favorite food!");
    }
    else
    {
      Console.WriteLine($"I have never heard of {userFavoriteFood}");
    }

    Console.WriteLine("Here are all of my favorite foods:");

    for (int i = 0; i < FavoriteFoods.Length; i++) //Iterates over favorite foods
    {
      Console.WriteLine($"{i + 1}. {FavoriteFoods[i]}");
    }

    Console.WriteLine($"I'm going to add you to my list of friends, {userName}");

    Friend user = new Friend(userName, userAge, userFavoriteFood);

    Friends.Add(user);

    Console.WriteLine("Here are all of my friends!");

    foreach (Friend friend in Friends)
    {
      Console.WriteLine($"My name is {friend.Name}! I am {friend.Age}, and my favorite food is {friend.FavoriteFood}");
    }
  }

  private static int GetUserAge()
  {
    string ageString = Console.ReadLine();

    bool success = int.TryParse(ageString, out int age); //Returns true or false based of of what is passed

    if (!success) //Does a check to make sure the input is a number
    {
      Console.WriteLine($"{ageString} was an invalid input, please enter age again");
      return GetUserAge();
    }

    return age;
  }
}


public class Friend
{

  public string Name { get; set; }
  public int Age { get; set; }
  public string FavoriteFood { get; set; }

  public Friend(string name, int age, string food) //This is a constructor like in js
  {
    Name = name;
    Age = age;
    FavoriteFood = food;
  }
}