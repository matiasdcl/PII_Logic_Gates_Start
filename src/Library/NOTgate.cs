namespace Library;

public class NOTgate : IValorVerdad
{
    private List<IValorVerdad> Entradas = new List<IValorVerdad>();

    public void AgregarValor(IValorVerdad valor)
    {
        if (Entradas.Count == 0)
        {
         Entradas.Add(valor);   
        }
    }

    public bool Calcular()
    {
        return !Entradas[0].Calcular();
    }
}
