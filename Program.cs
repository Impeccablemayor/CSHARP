

// Console.WriteLine("Enter your preferred name");
// // Console.Write("hello World");
// var username = Console.ReadLine();

// Console.WriteLine("username" + ": " + username);
// int obj = 10;
// Console.WriteLine( obj.GetType());

// // int mynum  = 120;
// Console.WriteLine(mynum);

// const int myName = 100;
// System.Console.WriteLine(myName);

// String firstName = "Mayowa"; 
// String lastName = "Binuyo"; 

// lastName = firstName + " " + lastName;
// System.Console.WriteLine("My name is " + lastName);

// int x = 10;
// int y = 11;
// System.Console.WriteLine(x + y);

//     int y = 10, x = 9, z = 2;
//     System.Console.WriteLine(x + y + z);
// 

//     int myNum = 5;               // Integer (whole number)
//     double myDoubleNum = 5.99D;  // Floating point number
//     // char myLetter = 'D';         // Character
//     // bool myBool = true;          // Boolean
//     string myText = "Hello";     // String

//     System.Console.WriteLine(myNum + myDoubleNum + myText);

// bool isMayowaABoy = true;
// bool isMayowaAGirl = false;

// Console.WriteLine(isMayowaABoy);
// Console.WriteLine(isMayowaAGirl);

// Typecasting 
// The order of datatype depending on the data size (smallest to the biggest)
//char -> int -> long -> float -> double


//upcasting or implicit
// char myUext = 'A';
// int myText2 = myUext;

//downcasting or explicit casting 
// float mayor = 1232.75F;
// int emma = (int) mayor;
// System.Console.WriteLine(emma);

// We have casting method ... Convert.toString, Convert.toInt32, Convert.toDouble
// int you;
// you = -10;

// // System.Console.WriteLine(Convert.ToChar(you)); // This throws an exception ThrowCharOverflowException()
// System.Console.WriteLine(Convert.ToString(you));
// System.Console.WriteLine(Convert.ToDouble(you));
// System.Console.WriteLine(you.GetType());

// To take input from user 
// var input = Console.ReadLine();
// System.Console.WriteLine("username:" +' '+ input);
// // another way to take input from user...
// Console.WriteLine("Username:"+ ' ' + Console.ReadLine());

// since readline gives string I explicitly converted it to integer (int32)..
// Console.WriteLine("Enter your age:");
// int age = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Your age is: " + age);

// int w = 3;
// int t = 3;
// int r = 4;
//     float u = 12.2F;

//     var sum = w + t; 
//     sum += r;

//     System.Console.WriteLine(sum);

// System.Console.WriteLine(w==t && t < r);
// System.Console.WriteLine(w==t && t > r);
// System.Console.WriteLine(w==t || t > r);
// System.Console.WriteLine(w!=t || t > r); 

// Math Method 

//sqrt to check square root
// System.Console.WriteLine(Math.Sqrt(144));
// // Min to check the smaller number
// System.Console.WriteLine(Math.Min(r, t));
// // Abs Absolute positive 
// System.Console.WriteLine(Math.Abs(-2.30));
// //Round() rounds a number to nearest
// System.Console.WriteLine(Math.Round(98.53278));

//Strings

// String greetings = "Hello!!";
// // System.Console.WriteLine(greetings);

// String txt = "uwhwuhwuhuwh12324u3huhufdhudhu.eeh983";
// System.Console.WriteLine("no. of characers in txt are:" + " " + txt.Length);


// // To uppercase 
// String text = "I want to be in uppercase";
// System.Console.WriteLine(text.ToUpper());
// // To lowercase
// System.Console.WriteLine(text.ToLower());


// // String Concatenation
// String Total = txt + text;
// System.Console.WriteLine(Total);
// // We can aLso use a method to concatenate two strings
// String All = String.Concat(txt,text);

//String interpolation  (It substitutes the value of variables into placeholders)
// String Fname = "Mayor";
// String Lname = "Binuyo";
// String Together = $"My fullname is: {Lname} {Fname}";
// System.Console.WriteLine(Together);

//Accessing strings using index number 

// String name = "Impeccable";
// System.Console.WriteLine(name[0]);

// We can find the index position of a specific character in a string, by using the IndexOf() method.
// int name1 = name.IndexOf("e");
// System.Console.WriteLine(name1);

// substring is used to extract character from the specified index/position (It used together with indexOf)

// String names = name.Substring(name1);
// System.Console.WriteLine(names);

// To be able to use quote, make use of backslash (\)
// String save = "Mayowa is good & excellent \\ guy \"he is truly Impeccable\" ";
// System.Console.WriteLine(save);

// We also have other ones like new line (\n), add tab (\t), add backspace (\b)

// string Try = "mayor\n you are good \t, me\byou";
// System.Console.WriteLine(Try);

// When adding two numbers with + it is called while when adding strings it is called concatenation.

// int x = 10;
// long e = 100L;
// float r = 102.3F;

// System.Console.WriteLine(x + e/r );


// Boolean 
// It is used to check if a statement is true or false....

// int y = 10, s= 11;
// bool isyten = true;
// bool issten = false;

// System.Console.WriteLine(isyten);
// System.Console.WriteLine(issten);

// This prints if y>s is true or false.
// System.Console.WriteLine(y>s);
// System.Console.WriteLine(y<s);

// This prints true or false if they are equal
// System.Console.WriteLine(y==s);
// System.Console.WriteLine(y!=s);
// System.Console.WriteLine(y>=s);
// System.Console.WriteLine(y<=s);
// System.Console.WriteLine(y<=s && y==s);   // the two has to be true for the output to be true.
// System.Console.WriteLine(y<=s || y!=s);  // either of the statement must be true for the output to be true



// conditions & if statements 
// if (condition) 
// {
// block of code to be executed if the condition is True
// }
// String mayor = "boy";
// System.Console.WriteLine("Pls enter the name!");
// String name = Console.ReadLine();
// if ( name == mayor){
// System.Console.WriteLine($"{name}  is a boy");
// }

// the else statement
// if(20<10){
// System.Console.WriteLine("20 is greater than 10");
// }
// else{
//     System.Console.WriteLine("20 is less than 10");
// }

// The Else if statement 
// if (condition1)
// {
// block of code to be executed if condition1 is True
// } 
// else if (condition2) 
// {
// block of code to be executed if the condition1 is false and condition2 is True
// } 
// else
// {
// block of code to be executed if the condition1 is false and condition2 is False
// }

// We also have the shorthand form for writing the if else statement 
// int time = 20;
// String result = (21 < time)? "21 is greater than time": "21 is less than time";
// System.Console.WriteLine(result);

// The switch statement
/*int day = 4;
switch (day)
{
    case 1:
    System.Console.WriteLine("This is sunday");
    break;
    case 2:
    System.Console.WriteLine("This is monday");
    break;
    case 3:
    System.Console.WriteLine("This is tuesday");
    break;
    case 4:
    System.Console.WriteLine("This is wednesday");
    break;
    case 5:
    System.Console.WriteLine("This is thursday");
    break;
    case 6:
    System.Console.WriteLine("This is friday");
    break;
    case 7:
    System.Console.WriteLine("This is saturday");
    break; */

//The result will be This is wednesday cos it's the case 4...
// The break keyword is to stop the execution of more code after reaching the desired condition.
// The default keyword is used to print a default outcome incase no case is match....

/*int day = 4;
switch (day) 
{
case 6:
  Console.WriteLine("Today is Saturday.");
  break;
case 7:
  Console.WriteLine("Today is Sunday.");
  break;
default:
  Console.WriteLine("Looking forward to the Weekend.");
  break;
}*/
// Outputs "Looking forward to the Weekend." since there is no case 4 

// Loops 
// While loop
// int day = 8;
// while (day <= 7)
// {
//   // code block to be executed
//   Console.WriteLine("Hello World");
// }
//

// do while loop 

// do
// {
//   System.Console.WriteLine(day);
//   day++;
// } while (day < 20);



//For loop
// we use For loop when we know exactly how many times we want to loop through a block of code.

// for (int i = 0; i < 7; i++)
// {
//   System.Console.WriteLine("God is Good to me!!!!");
// }

// for (int i = 0; i <= 17; i++)
// {
//   System.Console.WriteLine("God is Good to me!!!!");
// }

//foreach loop
/* string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
 foreach(string day in days){
   System.Console.WriteLine(day);
 }*/

// break and continue
/* for (int i = 0; i < 10; i++) 
{
if (i == 4) 
{
 break;
}
Console.WriteLine(i);
}*/

/* int y = 0;
 while (y < 10)
 {
   if (y == 5)
   {
     y++;
     continue;
   }
   System.Console.WriteLine(y);
   y++;
 }*/

// Arrays
// int[] books = { 10, 3, 9, 1 };
//     System.Console.WriteLine(books);
//     // elements of an array can be accessed using index no.
//   // index no. starts from 0
//   System.Console.WriteLine(books[0]);

// // elements of an array can be changed
// books[0] = 10;
// System.Console.WriteLine(books[0]);
// // You can check the array lenght
// System.Console.WriteLine(books.Length);

// we can loop through array and print out each element
// for (int i = 0; i < books.Length; i++)
// {
//     Console.WriteLine(books[i]);
// }

// foreach (int book in books){
//   System.Console.WriteLine(book);
// }

// sort a string 
// Array.Sort(books);
// foreach (int book in books)
// {
//   System.Console.WriteLine(book);
// }

// sort a string
/*String[] names= {"mayor", "emmanuel", "Adeshewa", "Tope"};
 Array.Sort(names);
foreach (string name in names)
{
  System.Console.WriteLine(name);
}*/

// Some other array methods that can be used 
/*int[] myNumbers = {5, 1, 8, 9};
      Console.WriteLine(myNumbers.Max());  // returns the largest value
      Console.WriteLine(myNumbers.Min());  // returns the smallest value
      Console.WriteLine(myNumbers.Sum());  // returns the sum of elements*/

// Create an array of four elements, and add values later
// string[] cars = new string[4];

// Create an array of four elements and add values right away 
// string[] cars = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

// Create an array of four elements without specifying the size 
// string[] cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

// Create an array of four elements, omitting the new keyword, and without specifying the size
// string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

// Declare an array
// string[] cars;

// Add values, using new
// cars = new string[] { "Volvo", "BMW", "Ford" };

// Add values without using new (this will cause an error)
// cars = { "Volvo", "BMW", "Ford"};




