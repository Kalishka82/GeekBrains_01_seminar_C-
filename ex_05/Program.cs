Console.WriteLine("Input any integer number: ");
string number = Console.ReadLine();
int N = int.Parse(number);
for (int i = -N; i <= N; i++)
{
    Console.Write(i);
    Console.Write(" ");
}