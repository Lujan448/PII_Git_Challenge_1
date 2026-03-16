public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Suma.Sumar(1, 2));
        Console.WriteLine(Resta.Restar(3, 4));
        Console.WriteLine(Multiplicacion.Multiplicar(5, 6));
        Console.WriteLine(Division.Dividir(7, 8));
    }
}
// Esta clase implementa la operación <nombre-operación>
public class Multiplication
{
   public static int Multiply(int a, int b)
   {
       return a * b;
    }

}

// Esta clase implementa la operación <suma>
public class Addition
{
   public static int Add(int a, int b)
   {
       return a + b;
   }
}

// Esta clase implementa la operación <division>
public class division
{
   public static double Divide(int a, int b)
   {
       return (double)a / b;
   }
}
git stash