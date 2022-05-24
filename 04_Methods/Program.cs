Methods _key = new Methods(); // this is a constructor, no parameters so it is an empty constructor


Console.WriteLine(_key.FullName("Trevor", "Stuart"));

string first = "Taylor";
string last = "Dickens";

string fullName = _key.FullName(last, first);

Console.WriteLine(fullName);

public class Methods
{
    public void ExplainMethod(int x)
    {
        //Method body
        Console.WriteLine("PUBLIC is the access modifier");
        Console.WriteLine("VOID is the return Type");
        Console.WriteLine("ExplainMethod is the Name");
        Console.WriteLine("int x is the parameter");
        Console.WriteLine("Name + Params = Signature");
    }

    public string FullName(string first, string last)
    {
        return $"{first} {last}";
    }
    // Console.WriteLine(FullName("Zack", "Barrell"))
}