//Value Types
//Value types are stored in the STACK vs HEAP (STACK is like local small shortterm memory, can hold int,  heap holds more complex types like reference types- string)
// STACK values- char, int, bool
bool isDeclared; //declairing 
isDeclared = true; // assigning value

char character = 'a'; //char is always single quotes in C#
char symbol = '?';
char space = ' ';

// Whole Numbers
int someNumber = 12; //noquotes, int max = 2147483647
byte age = 22; //bytes cant be negative- max out at 255
sbyte negativeNumber = -13; //signed bytes allow us to make negative numbers as long as its below +-128
uint unsignedInt 
short shortExample = 3245; 
// if you do need to make a big whole number variable type use long
long bigWholeNumber = 9223372036854775807;

//always try to use the data type that is the closest to the size of variable to save storage

// FLOATING POINT NUMBERS - not whole numbers- Use Suffixes-floats, doubles and decimals

float floatExample = 1.045436f;
double doubleExample = 8.34323d;
decimal decimalExample = 2.5363m;

float x = 1.123456789123456789123456789123456789123456789f; // prints to 7 decimal places
double y = 1.123456789123456789123456789123456789123456789d; // 17
decimal z = 1.123456789123456789123456789123456789123456789m; // 28

// Console.WriteLine(x);
// Console.WriteLine(y);
// Console.WriteLine(z);

enum PastryType { cake, cupcake, dognut, muffin }; //can be referenced with console.writeLine(pastryType.cake)or (PastryType[])

// DateTime is a value set, note: you can do math with this value type
// DateTimeOffSet

// Reference Types- stored on the HEAP. The STACK will still store something that points to the HEAP storage location

string firstName = "Bob";
string lastName = "Burger";

string compositeFullName = string.Format("Hi my name is {0} {1}", firstName, lastName);
string interpolationFullName = $"{firstName} {lastName}";

Console.WriteLine(compositeFullName);

//ARRAYS

string[] stringArray = { "hello", "world", } // only allowed to place strings in this array

//LISTS
list<string> listOfStrings = new List<string>();
listOfStrings.Add("dog"); 

//Queues and DICTIONARIES
Queue<string> firstInFirstOut = new Queue<string>();

Dictionary<int, string> keyAndValue = new Dictionary<int, string>();


