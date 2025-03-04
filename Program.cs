// Prompts the user to enter a whole number
Console.Write("Enter a whole number: ");
int userNumber = int.Parse(Console.ReadLine()); // Convert input to an integer

// Prints a message displaying the user's favorite number
Console.WriteLine($"Your favorite number is {userNumber}!");

// Ask the user a yes or no question
Console.Write("Do you like Reading books? (Enter 'true' or 'false'): ");
string userResponse = Console.ReadLine().Trim().ToLower();

// Converts the user's response to a boolean value
bool isTrue = userResponse == "true"; // If user enters "true", isTrue becomes true, otherwise false

// Prints the result with the boolean value
Console.WriteLine($"It is {isTrue} that I like Reading books!");
