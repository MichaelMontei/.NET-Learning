// See https://aka.ms/new-console-template for more information

// Chapter 1: Introduction to C#

// Console.WriteLine("Hello, World!");
// Console.WriteLine() prints a message to the output console after compiling and running the message. Doesn't let you write on the same line!

// Console.Write() prints a message to the output console, but let you print another line on the same line as the one before.
Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("You wrote your first lines of code!");

// Double quotation in C# code means it's a literal string -> we literally wanted to print the character H e l l o and so on.
// The Writeline() is called a method -> methods can be spot cause they always have parenthesis after it. 
// The Console part is part of a class -> Classes own Methods or a better way to say is that methods live inside classes.
// The Dot between Console and Writeline is called the member access operator -> In other words tells you how to navigate from the class to one of it's methods.

// Challenge 1: Use the two different techniques to print the two lines of the output.
// Output
// This is the first line.
// This is the second line.
Console.WriteLine("This is the first line.");

Console.Write("This is ");
Console.Write("the second ");
Console.Write("line.");

// Chapter 2: Store and Retrieve data using literal and variable values in C#

// To create a new variable you must always declare the type of that variable !!!
// string firstName;
// int 17;

// In this example we will set and get the values from variables
string lastName;
lastName = "Monteiro";
Console.WriteLine(lastName);

// Let's reassign the value of a variable
string firstName;
firstName = "Bob";
Console.WriteLine(firstName);
firstName = "Beth";
Console.WriteLine(firstName);
firstName = "Conrad";
Console.WriteLine(firstName);
firstName = "Grant";
Console.WriteLine(firstName);

// Let's initialize the value in our variable
string secondName = "Bob";
Console.WriteLine(secondName);

// Challenge 2: Store these 3 variables and make the following output on the screen
// Variables => Bob, 3, 34,4
// Output: Hello, Bob! You have 3 messages in your inbox. The temperature is 34.4 celsius.
string Name = "Bob";
int amount = 3;
decimal temperature = 34.4m;

Console.Write("Hello, ");
Console.Write(Name);
Console.Write("! You have ");
Console.Write(amount);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(temperature);
Console.Write(" celsius.");

// Chapter 3:  Perform basic string formatting in C# 

// Character escapes Sequence is a special instruction to the runtime if you want to insert a special character
// In C# we can use for example \n => this sequence will add a new line || \t sequence will add a tab.
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");

// We can also display directory paths by using two \\ to display a single backslash
Console.WriteLine("c:\\source\\repos");

// Let's create a mockup invoice sequence for our customer
Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

// So in our challenge we asked you to make a Japanese invoice too to be added to the normal one
// To generate Japanese invoices: we need to use a verbatim literal string meaning we can use a Unicode \u escape sequence and then a four code representing the character
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
Console.WriteLine(@"c:\invoices\app.exe -j");

// String Concatenation meaning simply combining two or more values into a new value
// We use the string concatenation operator for this which is the plus symbol +
string thirdName = "Michael";
string message = "Hello " + thirdName;
Console.WriteLine(message);

string fourthName = "Zeno";
string greeting = "Hello";
Console.WriteLine(greeting + " " + fourthName + "!");

// String Interpolation combines multiple values into a single string by using a "template". An interpolation Expression is a variable surrounded by an opening and closing curly brace symbol { }.
string fifthName = "Jos";
string greetingYou = "Hello";
Console.WriteLine($"{greetingYou} {fifthName}!");

// Simple addition and Implicit Data conversion
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

// Let's mix data types and force implicit type conversions
string sixthName = "Bob";
int widgetsSold = 7;
Console.WriteLine(sixthName + " sold " + widgetsSold + " widgets.");

// Math Operators and Order of operations
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

// Order of operations
// 1.Parentheses (whatever is inside the parentheses is performed first)
// 2.Exponents
// 3.Multiplication and Division (from left to right)
// 4.Addition and Subtraction (from left to right)

// Increment and Decrement Values
// The += operator adds and assigns the value on the right of the operator to the value on the left side.
int value = 0;
value = value + 5;
value += 5;

// There are many operators and these are known as compound operators
// Like +=, -=, *=, ++, and -- 

// Challenge 3: To convert temperatures in degrees Fahrenheit to Celsius, first subtract 32, then multiply by five ninths (5 / 9).
// int fahrenheit = 94;
// Output: The temperature is 34.444444444444444444444444447 Celsius.
int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine("The temperature is " + celsius + " Celsius.");

// Chapter 4: Call methods from the .NET Class Library using C#
// The .NET Class Library is a collection of thousands of classes containing thousands of methods. These methods were created by Microsoft and are available for use in your Applications.
// Namespace? -> Classes are organized into namespaces to prevent naming collisions. Think of it as a Lastname.
// Let's take a look at a different method in the .NET class Library
//Random dice = new Random(); //creates a new instance of the System.random class
//int roll = dice.Next(1, 7); //calls the dice object Next() method passing in two parameters
//Console.WriteLine(roll); //actual roll the dice and call the method and random numbers between 1,6 will appear.

// Chapter 5: Add decision logic to your code using `if`, `else`, and `else if` statements in C#
// We can use if statements to check something in our program
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if (total > 14)
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}

// We can also use Boolean Expressions in C#
string sentence = "The quick brown fox jumps over the lazy dog.";
bool result = sentence.Contains("dog");
Console.WriteLine(result);

if (sentence.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}

//Challenge 5: Improve renewal rate of subscriptions
// Starting point of the exercise ->

//Random random = new Random();
//int daysUntilExpiration = random.Next(12);
//int discountPercentage = 0;

// Your code goes here

// Rule 1. If the user's subscription will expire in 10 days or less, display the message:  Your subscription will expire soon. Renew now!
// Rule 2. If the user's subscription will expire in 5 days or less, display the messages: Your subscription expires in x days. Renew now and save 10%!
// Rule 3. If the user's subscription will expire in 1 day, display the message: Your subscription expires within a day! Renew now and save 20%!
// Rule 4. If the user's subscription has expired, display the message: Your subscription has expired.
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}