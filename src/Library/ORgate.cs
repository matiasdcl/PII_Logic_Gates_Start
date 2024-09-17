namespace Library;

public class ORgate : IValorVerdad
{
    private List<IValorVerdad> entradas;

    public void AgregarValor(IValorVerdad valorDeVerdad)
    {
        entradas.Add(valorDeVerdad);
    }
    
    public bool Calcular()
    {
        bool resultado = true;
        foreach (IValorVerdad valorDeVerdad in entradas)
        {
            resultado = resultado || valorDeVerdad.Calcular();
        }
        return resultado;
    }
}
