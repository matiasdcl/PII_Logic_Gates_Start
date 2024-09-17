namespace Library;

public class ANDgate : IValorVerdad
{
    public List<IValorVerdad> Entradas { get; } = new List<IValorVerdad>();

    public void AgregarValor(IValorVerdad valorVerdad)
    {
        this.Entradas.Add(valorVerdad);    
    }
    
    public bool Calcular()
    {
        bool result = true;
        foreach (IValorVerdad valor in this.Entradas)
        {
            result = result && valor.Calcular();
        }
        return result;
    }
}
