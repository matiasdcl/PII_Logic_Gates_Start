using Library;
namespace LibraryTests;

[TestFixture]
[TestOf(typeof(GarageGate))]
public class GarageGateTest
{

    [Test]
    public void TestOutputTrue1()
    {
        bool ExpectedResult = true;
        IValorVerdad a = new ValorVerdadFalse();
        IValorVerdad b = new ValorVerdadFalse();
        IValorVerdad c = new ValorVerdadTrue();
        Assert.AreEqual(ExpectedResult ,GarageGate.AbrirPuerta(a, b, c));
    }

    [Test]
    public void TestOutputTrue2()
    {
        bool ExpectedResult = true;
        IValorVerdad a = new ValorVerdadTrue();
        IValorVerdad b = new ValorVerdadTrue();
        IValorVerdad c = new ValorVerdadTrue();
        Assert.AreEqual(ExpectedResult ,GarageGate.AbrirPuerta(a, b, c));
    }

    [Test]
    public void TestOutputFalseRandom()
    {
        bool ExpectedResult = false;
        IValorVerdad a = new ValorVerdadFalse();
        IValorVerdad b = new ValorVerdadFalse();
        IValorVerdad c = new ValorVerdadFalse();
        Assert.AreEqual(ExpectedResult ,GarageGate.AbrirPuerta(a, b, c));
    }
}