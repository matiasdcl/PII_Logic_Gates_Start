namespace Library;

public class NOTgate : IValorVerdad
{
    private List<IValorVerdad> Entradas = new List<IValorVerdad>();

    public List<IValorVerdad> GetEntradas()
    {
        return Entradas;
    }
    
    public void AgregarValor(IValorVerdad valor)
    {
        if (Entradas.Count == 0)
        {
         Entradas.Add(valor);   
        }
        else
        {
            Console.WriteLine("La compuerta Not solo admite una entrada");
        }
    }

    public bool Calcular()
    {
        return !Entradas[0].Calcular();
    }
}
