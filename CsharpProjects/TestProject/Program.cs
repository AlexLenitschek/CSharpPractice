#region if, else and else if

// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);
// // int roll1 = 1;
// // int roll2 = 2;
// // int roll3 = 3;

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     if ((roll1 == roll2) && (roll2 == roll3))
//     {
//         Console.WriteLine("You rolled triples!  +6 bonus to total!");
//         total += 6;
//     }
//     else
//     {
//         Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//         total += 2;
//     }

//     Console.WriteLine($"Your total including the bonus: {total}");
// }

// if (total >= 16)
// {
//     Console.WriteLine("You win a new car!");
// }
// else if (total >= 10)
// {
//     Console.WriteLine("You win a new laptop!");
// }
// else if (total == 7)
// {
//     Console.WriteLine("You win a trip for two!");
// }
// else
// {
//     Console.WriteLine("You win a kitten!");
// }

#endregion

#region Even more if else stuff.

// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// // Your code goes here
// if (daysUntilExpiration == 0)
// {
//     Console.WriteLine("Your subscription has expired.");
// }
// else if (daysUntilExpiration == 1)
// {   
//     Console.WriteLine("Your subscription expires within a day!");
//     discountPercentage = 20;
// }
// else if (daysUntilExpiration > 1 && daysUntilExpiration <= 5)
// {
//     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days");
//     discountPercentage = 10;
// }
// else if (daysUntilExpiration > 5 && daysUntilExpiration <= 10)
// {
//     Console.WriteLine("Your subscription will expire soon, Renew now!");
// }
// else 
// {
//     Console.WriteLine($"Nothing to worry about, your Subscription only expires in {daysUntilExpiration} days");
// }
// if (discountPercentage > 0)
// {
//     Console.WriteLine("Renew now and save " + discountPercentage+"%!");
// }

#endregion


#region Arraystuff.
// /*
// string[] fraudulentOrderIDs = new string[3];

// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";
// // fraudulentOrderIDs[3] = "D000";
// */

// string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ];

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
// Console.WriteLine();

// int[] inventory = { 200, 450, 700, 175, 250 };
// int sum = 0;
// int bin = 0;
// foreach (int items in inventory)
// {
//     sum += items;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
// }
// Console.WriteLine($"We have {sum} items in inventory.");
// Console.WriteLine();


// string[] inventory2 = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

// foreach (var item in inventory2)
// {
//     if(item.StartsWith("B"))
//     {
//         Console.WriteLine(item);
//     }
// }

#endregion

#region Naming conventions and proper commenting.

// string firstName = "Bob";
// int widgetsPurchased = 7;
// // Testing a change to the message.
// // int widgetsSold = 7;
// // Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
// Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");

// /* <-- This is how you start a block comment.
// string firstName = "Bob";
// int widgetsPurchased = 7;
// Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
// */


// /* <-- Blocks like these above code instead of in-between lines can help in making it look cleaner and still explain the functionality.
//   The following code creates five random OrderIDs
//   to test the fraud detection process.  OrderIDs 
//   consist of a letter from A to E, and a three
//   digit number. Ex. A123.
// */
// Random random = new Random();
// string[] orderIDs = new string[5];

// for (int i = 0; i < orderIDs.Length; i++)
// {
//     int prefixValue = random.Next(65, 70);
//     string prefix = Convert.ToChar(prefixValue).ToString();
//     string suffix = random.Next(1, 1000).ToString("000");

//     orderIDs[i] = prefix + suffix;
// }

// foreach (var orderID in orderIDs)
// {
//     Console.WriteLine(orderID);
// }

// // The C# compiler ignores whitespace. You should still use them where they make sense!
// // Example 1:
// Console
// .
// WriteLine
// (
// "Hello Example 1!"
// )
// ;

// // Example 2:
// string firstWord="Hello";string lastWord="Example 2";Console.WriteLine(firstWord+" "+lastWord+"!");


// /*
//   This Code transforms a message into a char array, reverses it and counts the number of times a specific letter appears.
//   The reverse message and the counted result is then printed to the console.
// */
// string originalMessage = "The quick brown fox jumps over the lazy dog.";

// char[] charMessage = originalMessage.ToCharArray();
// Array.Reverse(charMessage);

// int oLetterCount = 0;

// foreach (char letter in charMessage) 
// { 
//     if (letter == 'o') 
//     { 
//         oLetterCount++;
//     } 
// }

// string newMessage = new String(charMessage);

// Console.WriteLine(newMessage);
// Console.WriteLine($"'o' appears {oLetterCount} times.");



#endregion