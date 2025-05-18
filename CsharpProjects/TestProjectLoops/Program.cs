using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

#region For loop
// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = names.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine(names[i]);
// }
#endregion


#region Do-While loop
// Random random = new Random();
// int current = 0;

// do
// {
//     current = random.Next(1, 11);
//     Console.WriteLine(current);
// } while (current != 7);
#endregion

#region While loop
// Random random = new Random();
// int current = random.Next(1, 11);

// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");
#endregion

#region Continue statement
// Random random = new Random();
// int current = random.Next(1, 11);

// do
// {
//     current = random.Next(1, 11);

//     if (current >= 8) continue;

//     Console.WriteLine(current);
// } while (current != 7);
#endregion

#region Exercise 1 Mini Game

// Random random = new Random();
// int damage = random.Next(1, 7);
// int heroHealth = 10;
// int monsterHealth = 10;

// do
// {
//     damage = random.Next(1, 7);
//     monsterHealth = monsterHealth - damage;
//     Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monsterHealth} health.");
//     if (monsterHealth <= 0)
//     {
//         Console.WriteLine("Hero Wins!");
//         break;
//     }
//     damage = random.Next(1, 7);
//     heroHealth = heroHealth - damage;
//     Console.WriteLine($"Hero was damaged and lost {damage} health and now has {heroHealth} health.");
//     if (heroHealth <= 0)
//     {
//         Console.WriteLine("The hero died. The monster has won!");
//         break;
//     }
// }
// while (heroHealth > 0 && monsterHealth > 0); 

#endregion

#region Exercise 2 User Integer Input

// string? readResult;
// bool validEntry = false;
// int number;
// Console.WriteLine("Enter an integer value between 5 and 10");
// do
// {
//     readResult = Console.ReadLine();
//     validEntry = int.TryParse(readResult, out number);
//     if (validEntry)
//     {
//         if (number > 4 && number < 6)
//         {
//             validEntry = true;
//             Console.WriteLine($"Your input value ({number}) has been accepted.");
//         }
//         else
//         {
//             Console.WriteLine($"You entered {number}. Please enter a number between 5 and 10.");
//             validEntry = false;
//             continue;
//         }
//     }
//     else
//     {
//         Console.WriteLine("Sorry, you entered an invalid number, please try again");
//     }
// } while (validEntry == false);

#endregion

#region Exercise3 User string Input

// Console.WriteLine("Enter your role name (Administrator, Manager or User)");
// bool userInput = false;
// do
// {
//     string? stringInput = Console.ReadLine();
//     if (stringInput == "Administrator" || stringInput == "Manager" || stringInput == "User")
//     {
//         Console.WriteLine($"Your input value ({stringInput}) has been accepted.");
//         userInput = true;
//     }
//     else
//     {
//         Console.WriteLine($"The role name that you entered, \"{stringInput}\" is not valid. Enter your role name (Administrator, Manager, or User)");
//         continue;
//     }
// }
// while (userInput == false);

#endregion

#region TryParse

// string value = "bad";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//    Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//    Console.WriteLine("Unable to report the measurement.");
// }

// if (result > 0)
//    Console.WriteLine($"Measurement (w/ offset): {50 + result}");

// Console.WriteLine($"{result}");
#endregion

#region TryParse exercise

// string[] values = { "12.3", "45", "ABC", "11", "DEF" };
// decimal result = 0;
// decimal counter = 0;
// string? stringResult = "";

// foreach (string value in values)
// {
//     if (decimal.TryParse(value, out counter))
//     {
//         result += counter;
//     }
//     else
//     {
//         stringResult = stringResult + value;
//     }
// }

// Console.WriteLine($"Message: {stringResult}");
// Console.WriteLine($"Total: {result}");

#endregion

#region TryParse Exercise 2

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
int result1 = Convert.ToInt32(value1 / value2);

decimal result2 = value2 / (decimal)value3;

float result3 = (float)value3 / value1;
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

#endregion