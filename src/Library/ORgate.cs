namespace Library;

public class ORgate : IValorVerdad
{
    private List<IValorVerdad> entradas = new List<IValorVerdad>();

    public List<IValorVerdad> GetEntradas()
    {
        return entradas;
    }

    public void AgregarValor(IValorVerdad valorDeVerdad)
    {
        entradas.Add(valorDeVerdad);
    }
    
    public bool Calcular()
    {
        bool resultado = false;
        foreach (IValorVerdad valorDeVerdad in entradas)
        {
            resultado = resultado || valorDeVerdad.Calcular();
        }
        return resultado;
    }
}
