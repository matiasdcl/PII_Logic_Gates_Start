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
    public void TestComportamientoTrueTrue()
    {
        ORgate or = new ORgate();
        IValorVerdad a = new ValorVerdadTrue();
        IValorVerdad b = new ValorVerdadTrue();
        or.AgregarValor(a);
        or.AgregarValor(b);
        Assert.AreEqual(true,or.Calcular());
    }
    
    [Test]
    public void TestComportamientoFalseTrue()
    {
        ORgate or = new ORgate();
        IValorVerdad a = new ValorVerdadFalse();
        IValorVerdad b = new ValorVerdadTrue();
        or.AgregarValor(a);
        or.AgregarValor(b);
        Assert.AreEqual(true,or.Calcular());
    }
    
    [Test]
    public void TestComportamientoTrueFalse()
    {
        ORgate or = new ORgate();
        IValorVerdad a = new ValorVerdadTrue();
        IValorVerdad b = new ValorVerdadFalse();
        or.AgregarValor(a);
        or.AgregarValor(b);
        Assert.AreEqual(true,or.Calcular());
    }
    
    [Test]
    public void TestComportamientoFalseFalse()
    {
        ORgate or = new ORgate();
        IValorVerdad a = new ValorVerdadFalse();
        IValorVerdad b = new ValorVerdadFalse();
        or.AgregarValor(a);
        or.AgregarValor(b);
        Assert.AreEqual(false,or.Calcular());
    }
}