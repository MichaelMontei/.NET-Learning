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