//Loops

// Types of loops: FOR, WHILE, FOR EACH, DO-WHILE

//While

int total = 1;
while (total != 8) //while (Condition) must be able to evaluate to T/F
{
    Console.WriteLine("Just keep swimming...");
    Console.ReadKey();
    total += 1; // prints Just keep swimming until total = 8
}

bool isRunning = true;
total = 1;
while (isRunning)
{
    Console.WriteLine("Just Keep swimming...");

    if (total == 4)
    {
        isRunning = false;
    }
    total++;
}

//DO WHILE (do once then check before doing it again) Will always exicute at least once. While loops do not have to exicute if = false

int iterator = 0;
do{
    Console.WriteLine("Hi");
    iterator++;
}
while (iterator < 5);

// FOR LOOP

total = 10;
for (int i = 0; i < total; i += 2)
{
    Console.WriteLine("Another one - DJ khaled.");
}

string[] students = { "Harry", "Lloyd", "Thelma", "Louise", "Pippin", "Merry" };

for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine($"Welcome to EFA, {students[i]}");
}

List<String> roster = new List<string>() {"Harry", "Lloyd", "Thelma", "Louise", "Pippin", "Merry"};

for (int i = 0; i < roster.Count(); i++) //Count is used for iterating over lists
{
    Console.WriteLine($"Welcome to EFA, {roster[i]}");
}

//FOR EACH
foreach (string name in roster)
{
    foreach (char x in name)
    {
        Console.Write(char.ToUpper(x));
    }
        Console.Write("\n");
}

