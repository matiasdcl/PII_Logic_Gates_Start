using Library;

namespace LibraryTests;

[TestFixture]
public class ANDgateTest
{
    [Test]
    public void TestCalcular()
    {
        ANDgate and1 = new ANDgate();
        IValorVerdad a = new ValorVerdadFalse();
        IValorVerdad b = new ValorVerdadFalse();
        and1.AgregarValor(a);
        and1.AgregarValor(b);
        Assert.That(!and1.Calcular());
        
        ANDgate and2 = new ANDgate();
        IValorVerdad c = new ValorVerdadTrue();
        IValorVerdad d = new ValorVerdadFalse();
        and2.AgregarValor(c);
        and2.AgregarValor(d);
        Assert.That(!and2.Calcular());
        
        ANDgate and3 = new ANDgate();
        IValorVerdad e = new ValorVerdadTrue();
        IValorVerdad f = new ValorVerdadTrue();
        and3.AgregarValor(e);
        and3.AgregarValor(f);
        Assert.That(and3.Calcular());
    }
}