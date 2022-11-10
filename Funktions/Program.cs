Console.WriteLine("Are ypu coming or not? (in/out)");
string userChoise = Console.ReadLine();

if(userChoise == "in")
{
    PrintHello();
}
else
{
    PrintGoodBye(); 
}




static void PrintHello() //funktion ehk meetod
{
    Console.WriteLine("Hello, world!");
}

static void PrintGoodBye() //funktion ehk meetod
{
    Console.WriteLine("See you later!");
}