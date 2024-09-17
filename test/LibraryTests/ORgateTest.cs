using Library;

namespace LibraryTests;

[TestFixture]
public class ORgateTest
{
    
    [Test]
    public void TestAgregarValor()
    {
        ORgate or = new ORgate();
        IValorVerdad a = new ValorVerdadTrue();
        or.AgregarValor(a);
        Assert.That(or.GetEntradas().Contains(a));
        IValorVerdad b = new ValorVerdadFalse();
        or.AgregarValor(b);
        Assert.That(or.GetEntradas().Contains(b));
    }

    [Test]
    public void TestCalcular()
    {
        ORgate or1 = new ORgate();
        IValorVerdad a = new ValorVerdadTrue();
        IValorVerdad b = new ValorVerdadTrue();
        or1.AgregarValor(a);
        or1.AgregarValor(b);
        Assert.AreEqual(true,or1.Calcular());
        
        ORgate or2 = new ORgate();
        IValorVerdad c = new ValorVerdadFalse();
        IValorVerdad d = new ValorVerdadTrue();
        or2.AgregarValor(c);
        or2.AgregarValor(d);
        Assert.AreEqual(true,or2.Calcular());
        
        ORgate or3 = new ORgate();
        IValorVerdad e = new ValorVerdadTrue();
        IValorVerdad f = new ValorVerdadFalse();
        or3.AgregarValor(e);
        or3.AgregarValor(f);
        Assert.AreEqual(true,or3.Calcular());
        
        ORgate or4 = new ORgate();
        IValorVerdad g = new ValorVerdadFalse();
        IValorVerdad h = new ValorVerdadFalse();
        or4.AgregarValor(g);
        or4.AgregarValor(h);
        Assert.AreEqual(false,or4.Calcular());
    }
}