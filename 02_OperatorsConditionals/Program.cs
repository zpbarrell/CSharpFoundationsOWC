// //Operators

// //Arithmetic Op

// //Addition
// int intA = 20;
// int intB = 21;
// int sum = intA + intB;
// sum += 7;
// // console.WriteLine(sum);

// //Subtraction
// int difference = intA - intB;
// difference -+ -7;
// // Console.WriteLine(difference);

// //Multiplication
// int product = intA * intB;
// product *= 2;

// // console.WriteLine(product);

// //Division
// int quotient = intA / intB;

// // Console.WriteLine(quotient);

// //remainder
// int remainder = intA % intB;


//Dates
DateTime today = DateTime.Now;
DateTime someOtherDay = new DateTime(1978, 1, 1);
TimeSpan timeSpan = today - someOtherDay;

Console.WriteLine(timeSpan);

// Comparison Operators
int age = 25;
string userName = "Harry";

bool equals = age == 41; //false
bool isCorrectUsername = userName == "Lloyd"; //false

bool notEqual = age != 30; //true
bool isNotUser = userName != "Darryl";

bool greaterThan = age > 12;
bool lessThan = age < 50;

bool greaterThanOrEqual = age >= 2345;
bool lessThanOrEqual = age <= 1;

// || OR, && AND

bool trueValue = true;
boolfalseValue = false;

bool trueAndTrue = trueValue && falseValue;

int xyz = 10;
int abc = 12;
if(xyz > 9 && abc < 14)
{
    Console.WriteLine(true);
}

//IF Statements

bool isHungry = true;
if(isHungry && age >= 21) 
{
    Console.WriteLine("Eat, bitch");
}

//IF ELSE
bool tpsReportsAreFinished = true;
if(tpsReportsAreFinished)
{
    Console.WriteLine("Dont work on saturday")
}
else
{
    Console.WriteLine("We're gonna need you to come in on saturday.")

}

//Else if

//Nested

tpsReportsAreFinished = true;
bool bossDoesntCare = true;

if(tpsReportsAreFinished)
{
    Console.WriteLine("You dont have to come in.");
}
else
{
    if(bossDoesntCare)
    {
        Console.WriteLine("You dont have to come in.");
    }
    else
    {
        Console.WriteLine("Sorry bud, gotta work on saturday because the boss cares");
    }
}

//Switch cases
int input = 1;
switch(input)
{
    case 1:
        Console.WriteLine("Its a One");
        break;
    case 2:
        Console.WriteLine("Its a TWO");
        break;
    case 3:
        Console.WriteLine("Its a THREE");
        break;
    default:
        console.WriteLine("I dunno.");
}

//Ternaries
//bool VARIABLE = CONDITIONAL ? OUTPUT_IF_TRUE : OUTPUT_IF_FALSE ;

age = 35;

bool canDrink = (age >= 21) ? true : false;