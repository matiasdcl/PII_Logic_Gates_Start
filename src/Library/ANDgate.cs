namespace Library;

public class ANDgate : IValorVerdad
{
    private List<IValorVerdad> entradas  = new List<IValorVerdad>();

    public void AddEntrada(IValorVerdad valorVerdad)
    {
        this.entradas.Add(valorVerdad);    
    }
    
    public bool Calcular()
    {
        bool result = true;
        foreach (IValorVerdad valor in entradas)
        {
            result = result && valor.Calcular();
        }
        return result;
    }
}
