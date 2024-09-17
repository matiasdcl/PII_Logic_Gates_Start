using Library;

public class Program
{
    public static void Main()
    {
        IValorVerdad a = new ValorVerdadFalse();
        IValorVerdad b = new ValorVerdadFalse();
        IValorVerdad c = new ValorVerdadFalse();
        Console.WriteLine(GarageGate.AbrirPuerta(a, b, c));
        
    }
}