#region Example Method.

// Console.WriteLine("Generating random numbers:");
// DisplayRandomNumbers();

// void DisplayRandomNumbers()
// {
//     Random random = new Random();

//     for (int i = 0; i < 5; i++)
//     {
//         Console.Write($"{random.Next(1, 100)} ");
//     }

//     Console.WriteLine();
// }

#endregion

#region Using methods to not repeat code.
// using System;

// int[] times = { 800, 1200, 1600, 2000 };
// int diff = 0;

// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Current Medicine Schedule:");

// /* Format and display medicine times */
// DisplayTimes();

// Console.WriteLine("Enter new GMT");
// int newGMT = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
// {
//     Console.WriteLine("Invalid GMT");
// }
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
// {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//     AdjustTimes();
// }
// else
// {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//     AdjustTimes();
// }

// Console.WriteLine("New Medicine Schedule:");

// /* Format and display medicine times */
// DisplayTimes();

// Console.WriteLine();





// void DisplayTimes()
// {
//     /* Format and display medicine times */
//     foreach (int val in times)
//     {
//         string time = val.ToString();
//         int len = time.Length;

//         if (len >= 3)
//         {
//             time = time.Insert(len - 2, ":");
//         }
//         else if (len == 2)
//         {
//             time = time.Insert(0, "0:");
//         }
//         else
//         {
//             time = time.Insert(0, "0:0");
//         }

//         Console.Write($"{time} ");
//     }

//     Console.WriteLine();
// }

// void AdjustTimes()
// {
//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     for (int i = 0; i < times.Length; i++)
//     {
//         times[i] = ((times[i] + diff)) % 2400;
//     }
// }

#endregion

#region Little method exercise.

// string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
// string[] address;
// bool validLength = false;
// bool validZeroes = false;
// bool validRange = false;

// /*
// if ipAddress consists of 4 numbers
// and
// if each ipAddress number has no leading zeroes
// and
// if each ipAddress number is in range 0 - 255

// then ipAddress is valid

// else ipAddress is invalid
// */
// foreach (string ip in ipv4Input) 
// {
//     address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

//     ValidateLength(); 
//     ValidateZeroes(); 
//     ValidateRange();

//     if (validLength && validZeroes && validRange) 
//     {
//         Console.WriteLine($"{ip} is a valid IPv4 address");
//     } 
//     else 
//     {
//         Console.WriteLine($"{ip} is an invalid IPv4 address");
//     }
// }

// void ValidateLength() 
// {
//     validLength = address.Length == 4;
// };

// void ValidateZeroes() 
// {
//     foreach (string number in address) 
//     {
//         if (number.Length > 1 && number.StartsWith("0")) 
//         {
//             validZeroes = false;
//             return;
//         }
//     }

//     validZeroes = true;
// }

// void ValidateRange() 
// {
//     foreach (string number in address) 
//     {
//         int value = int.Parse(number);
//         if (value < 0 || value > 255) 
//         {
//             validRange = false;
//             return;
//         }
//     }
//     validRange = true;
// }

#endregion

#region Exercise: Restructure Code to use Methods.


// Random random = new Random();
// DisplayFortune();


// void DisplayFortune()
// {
//     Console.WriteLine("A fortune teller whispers the following words:");
//     int luck = random.Next(100);
//     string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
//     string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
//     string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
//     string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };
//     string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
//     for (int i = 0; i < 4; i++)
//     {
//         Console.Write($"{text[i]} {fortune[i]} ");
//     }
// }

#endregion

#region Exercise: Add parameters to methods.

// int[] schedule = { 800, 1200, 1600, 2000 };
// DisplayAdjustedTimes(schedule, 6, -6);

// void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
// {
//     int diff = 0;
//     if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//     {
//         Console.WriteLine("Invalid GMT");
//     }
//     else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
//     {
//         diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//     }
//     else
//     {
//         diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//     }
//     for (int i = 0; i < times.Length; i++)
//     {
//         int newTime = ((times[i] + diff)) % 2400;
//         Console.WriteLine($"{times[i]} -> {newTime}");
//     }
// }
#endregion

#region Scopes - Value Types.

// int a = 3;
// int b = 4;
// int c = 0;

// Multiply(a, b, c);
// Console.WriteLine($"global statement: {a} x {b} = {c}");

// void Multiply(int a, int b, int c)
// {
//     c = a * b;
//     Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
// }

// /*
// inside Multiply method: 3 x 4 = 12
// global statement: 3 x 4 = 0
// Notice that the value of c is only altered within the Multiply method. Outside of the method, c retains its original value.
// That's because Methods take value type parameters as copies of the original and therefore don't change the original.
// Reference types like string, array or objects are taken by references. Changes in methods do change the original.
// */

#endregion

#region More Scopes - Reference Types.

// int[] array = {1, 2, 3, 4, 5};

// PrintArray(array);
// Clear(array);
// PrintArray(array);

// void PrintArray(int[] array) 
// {
//     foreach (int a in array) 
//     {
//         Console.Write($"{a} ");
//     }
//     Console.WriteLine();
// }

// void Clear(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = 0;
//     }
// }

// /*
// 1 2 3 4 5 
// 0 0 0 0 0
// Notice that the array remains altered outside of the Clear method scope. This happens because the Clear method updated the values stored at each address.
// */

// string status = "Healthy";

// Console.WriteLine($"Start: {status}");
// //SetHealth(status, false);
// SetHealth(false);
// Console.WriteLine($"End: {status}");

// // void SetHealth(string status, bool isHealthy)  // <-- New status variable defined here. Original is left untouched.
// // {
// //     status = (isHealthy ? "Healthy" : "Unhealthy");
// //     Console.WriteLine($"Middle: {status}");
// // }

// void SetHealth(bool isHealthy)
// {
//     status = (isHealthy ? "Healthy" : "Unhealthy");
//     Console.WriteLine($"Middle: {status}");
// }

#endregion

#region Exercise: Optional parameters.

// string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
// string[] rsvps = new string[10];
// int count = 0;
// // These are complete
// // RSVP("Rebecca", 1, "none", true);
// // RSVP("Nadia", 2, "Nuts", true);
// // RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false); // Named arguments to improve readability.
// // RSVP("Tony", inviteOnly: true, allergies: "Jackfruit",  partySize: 1); // Named arguments can appear in different order.
// // RSVP("Noor", 4, "none", false);
// // RSVP("Jonte", 2, "Stone fruit", false);
// // ShowRSVPs();

// // These use optional parameters
// RSVP("Rebecca");
// RSVP("Nadia", 2, "Nuts");
// RSVP(name: "Linh", partySize: 2, inviteOnly: false); // Named arguments to improve readability.
// RSVP("Tony", allergies: "Jackfruit", inviteOnly: true); // Named arguments can appear in different order.
// RSVP("Noor", 4, inviteOnly: false);
// RSVP("Jonte", 2, "Stone fruit", false);
// ShowRSVPs();

// void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
// {
//     if (inviteOnly)
//     {
//         bool found = false;
//         foreach (string guest in guestList)
//         {
//             if (guest.Equals(name))
//             {
//                 found = true;
//                 break;
//             }
//         }
//         if (!found)
//         {
//             Console.WriteLine($"Sorry, {name} is not on the guest list");
//             return;
//         }
//     }

//     rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
//     count++;
// }

// void ShowRSVPs()
// {
//     Console.WriteLine("\nTotal RSVPs:");
//     for (int i = 0; i < count; i++)
//     {
//         Console.WriteLine(rsvps[i]);
//     }
// }

#endregion

#region Exercise: Display email addresses.

// string[,] corporate = 
// {
//     {"Robert", "Bavin"}, {"Simon", "Bright"},
//     {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
//     {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
// };

// string[,] external = 
// {
//     {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
//     {"Shay", "Lawrence"}, {"Daren", "Valdes"}
// };

// string externalDomain = "hayworth.com";

// for (int i = 0; i < corporate.GetLength(0); i++) 
// {
//     DisplayCorporate(corporate[i, 0], corporate[i, 1]);
// }

// for (int i = 0; i < external.GetLength(0); i++)
// {
//     DisplayExternal(external[i, 0], external[i, 1], externalDomain);
// }

// void DisplayCorporate(string firstName, string lastName)
// {
//     string firstTwoLetters = "";
//     for (int j = 0; j < 2; j++)
//     {
//         if (firstName[j] != -1)
//         {
//             firstTwoLetters = firstTwoLetters + firstName.ToLower()[j];
//         }
//     }
//     string mailName = firstTwoLetters + lastName.ToLower() + "@" + "contoso.com";
//     Console.WriteLine(mailName);
// }

// void DisplayExternal(string firstName, string lastName, string externalDomain)
// {
//     string firstTwoLetters = "";
//     for (int j = 0; j < 2; j++)
//     {
//         if (firstName[j] != -1)
//         {
//             firstTwoLetters = firstTwoLetters + firstName.ToLower()[j];
//         }
//     }
//     string mailName = firstTwoLetters + lastName.ToLower() + "@" + externalDomain;
//     Console.WriteLine(mailName);
// }

/*
Expected Output:
robavin@contoso.com
sibright@contoso.com
kisinclair@contoso.com
aakamath@contoso.com
sadelucchi@contoso.com
siali@contoso.com
viashton@hayworth.com
codysart@hayworth.com
shlawrence@hayworth.com
davaldes@hayworth.com
*/

#endregion

#region Exercise: Methods with return values.

// double total = 0;
// double minimumSpend = 30.00;

// double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
// double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

// for (int i = 0; i < items.Length; i++)
// {
//     total += GetDiscountedPrice(i);
// }

// total -= TotalMeetsMinimum() ? 5.00 : 0.00; // Same as:  if (TotalMeetsMinimum()) {total -= 5.00;}

// Console.WriteLine($"Total: ${FormatDecimal(total)}");

// double GetDiscountedPrice(int itemIndex)
// {
//     return items[itemIndex] * (1 - discounts[itemIndex]);
// }

// bool TotalMeetsMinimum()
// {
//     return total >= minimumSpend;
// }

// string FormatDecimal(double input)
// {
//     return input.ToString().Substring(0, 5);
// }

#endregion

#region Exercise: Return numbers from methods.

// double usd = 23.73;
// int vnd = UsdToVnd(usd);

// Console.WriteLine($"${usd} USD = ${vnd} VND");
// Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

// int UsdToVnd(double usd)
// {
//     int rate = 23500;
//     return (int)(rate * usd);
// }

// double VndToUsd(int vnd) 
// {
//     double rate = 23500;
//     return vnd / rate;
// }

#endregion

#region Exercise: Reverse and Return a String.

// string input = "there are snakes at the zoo";

// Console.WriteLine(input);
// Console.WriteLine(ReverseSentence(input));
// string ReverseWord(string word)
// {
//     string result = "";
//     for (int i = word.Length - 1; i >= 0; i--)
//     {
//         result += word[i];
//     }
//     return result;
// }

// string ReverseSentence(string input) 
// {
//     string result = "";
//     string[] words = input.Split(" ");

//     foreach(string word in words) 
//     {
//         result += ReverseWord(word) + " ";
//     }

//     return result.Trim();
// }

#endregion

#region Exercise: Return booleans from methods.

// string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};

// Console.WriteLine("Is it a palindrome?");
// foreach (string word in words) 
// {
//     Console.WriteLine($"{word}: {IsPalindrome(word)}");
// }

// bool IsPalindrome(string word) 
// {
//     int start = 0;
//     int end = word.Length - 1;

//     while (start < end) 
//     {
//         if (word[start] != word[end]) 
//         {
//             return false;
//         }
//         start++;
//         end--;
//     }

//     return true;
// }

#endregion

#region Return Arrays from methods.

// int target = 55;
// int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
// int[,] result = TwoCoins(coins, target);

// if (result.Length == 0) 
// {
//     Console.WriteLine("No two coins make change");
// } 
// else 
// {
//     Console.WriteLine("Change found at positions:");
//     for (int i = 0; i < result.GetLength(0); i++) 
//     {
//         if (result[i,0] == -1) 
//         {
//             break;
//         }
//         Console.WriteLine($"{result[i,0]},{result[i,1]}");
//     }
// }

// int[,] TwoCoins(int[] coins, int target) 
// {
//     int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
//     int count = 0;

//     for (int curr = 0; curr < coins.Length; curr++) 
//     {
//         for (int next = curr + 1; next < coins.Length; next++) 
//         {
//             if (coins[curr] + coins[next] == target) 
//             {
//                 result[count, 0] = curr;
//                 result[count, 1] = next;
//                 count++;
//             }
//             if (count == result.GetLength(0)) 
//             {
//                 return result;
//             }
//         }
//     }
//     return (count == 0) ? new int[0,0] : result;
// }

#endregion

#region 

// Random random = new Random();


// Console.WriteLine("Would you like to play? (Y/N)");
// if (ShouldPlay()) 
// {
//     PlayGame();
// }

// void PlayGame()
// {
//     var play = true;

//     while (play)
//     {
//         var target = random.Next(1, 6);
//         var roll = random.Next(1, 7);

//         Console.WriteLine($"Roll a number greater than {target} to win!");
//         Console.WriteLine($"You rolled a {roll}");
//         Console.WriteLine(WinOrLose(target, roll));
//         Console.WriteLine("\nPlay again? (Y/N)");

//         play = ShouldPlay();
//     }
// }

// bool ShouldPlay()
// {
//     if (Console.ReadLine()?.ToLower() == "y")
//         return true;
//     else
//         return false;
// }

// string WinOrLose(int target, int roll)
// {
//     if (target > roll)
//         return $"You have lost.";
//     else if (target == roll)
//         return $"Both sides threw a {roll}, No one Wins!";
//     else
//                 return $"You win!";
// }

#endregion

#region Guided Project - Plan a petting Zoo visit.

/*
- There will be three visiting schools
    - School A has six visiting groups (the default number)
    - School B has three visiting groups
    - School C has two visiting groups

- For each visiting school, perform the following tasks
    - Randomize the animals
    - Assign the animals to the correct number of groups
    - Print the school name
    - Print the animal groups
*/
using System;

string[] pettingZoo =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);

void PlanSchoolVisit(string schoolName, int groups = 6)
{
    RandomizeAnimals();
    string[,] group = AssignGroup(groups);
    Console.WriteLine(schoolName);
    PrintGroup(group);
}

void RandomizeAnimals()
{
    Random random = new Random();

    for (int i = 0; i < pettingZoo.Length; i++)
    {
        int r = random.Next(i, pettingZoo.Length);

        string temp = pettingZoo[i];
        pettingZoo[i] = pettingZoo[r];
        pettingZoo[r] = temp;
    }
}


string[,] AssignGroup(int groups = 6)
{
    string[,] result = new string[groups, pettingZoo.Length / groups];
    int start = 0;

    for (int i = 0; i < groups; i++) // i < result.GetLength(0);
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = pettingZoo[start++];
        }
    }

    return result;
}

void PrintGroup(string[,] group) 
{
    for (int i = 0; i < group.GetLength(0); i++) 
    {
        Console.Write($"Group {i + 1}: ");
        for (int j = 0; j < group.GetLength(1); j++) 
        {
            Console.Write($"{group[i,j]}  ");
        }
        Console.WriteLine();
    }
}

#endregion
