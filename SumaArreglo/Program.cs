int [] vector2 = new int [5];
int [] vector1 = new int [5];
int [] SumaVector = new int [5];

Console.WriteLine("Ingrese los elementos del primer vector: ");
for(int i=0; i<vector1.Length; i++)
{
    try
    {
        Console.WriteLine($"Elemento {i+1}: ");
        vector1[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no valida. Por favor, ingrese un numero entero.");
        Console.ResetColor();
        i--;
    }
}

Console.WriteLine("Ingrese los elementos del segundo vector: ");
for(int i=0; i<vector2.Length; i++)
{
    try
    {
        Console.WriteLine($"Elemento {i+1}: ");
        vector2[i] = int.Parse(Console.ReadLine()!);
    }
    catch
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no valida, ingrese un numero valido.");
        Console.ResetColor();
    }
}

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("La sumatoria de los vectores es de: ");
for(int i=0; i < SumaVector.Length; i++)
{
    SumaVector[i] = vector1[i] + vector2[i];
}
Console.ResetColor();

for(int i=0; i< SumaVector; i++)
{
    Console.WriteLine($"")
}