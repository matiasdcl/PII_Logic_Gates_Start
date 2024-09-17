namespace Library;

public class ANDgate : IValorVerdad
{
    private List<IValorVerdad> entradas { get; } = new List<IValorVerdad>();

    public void AgregarValor(IValorVerdad valorVerdad)
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
