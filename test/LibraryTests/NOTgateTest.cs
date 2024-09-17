using Library;

namespace LibraryTests;

[TestFixture]
[TestOf(typeof(NOTgate))]
public class NOTgateTest
{

    [Test]
    public void TestAgregarValor()
    {
        NOTgate not1 = new NOTgate();
        IValorVerdad verdadero = new ValorVerdadTrue();
        not1.AgregarValor(verdadero);
        Assert.That(not1.GetEntradas().Count, Is.EqualTo(1));

        IValorVerdad falso = new ValorVerdadFalse();
        not1.AgregarValor(falso);
        Assert.That(not1.GetEntradas().Count, Is.EqualTo(1));
    }
    
    [Test]
    public void TestCalcular()
    {
        NOTgate not1 = new NOTgate();
        IValorVerdad verdadero = new ValorVerdadTrue();
        not1.AgregarValor(verdadero);
        Assert.That(not1.Calcular(), Is.EqualTo(false));

        NOTgate not2 = new NOTgate();
        IValorVerdad falso = new ValorVerdadFalse();
        not2.AgregarValor(falso);
        Assert.That(not2.Calcular(), Is.EqualTo(true));

    }
}