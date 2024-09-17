using System.Collections.Specialized;

namespace Library;

public class GarageGate
{
    public static bool AbrirPuerta(IValorVerdad a, IValorVerdad b, IValorVerdad c)
    {
        ANDgate and1 = new ANDgate();
        ANDgate and2 = new ANDgate();
        ANDgate and3 = new ANDgate();
        ORgate or1 = new ORgate();
        NOTgate not1 = new NOTgate();
        NOTgate not2 = new NOTgate();

        and1.AgregarValor(a);
        and1.AgregarValor(b);
        not1.AgregarValor(a);
        not2.AgregarValor(b);
        and2.AgregarValor(not1);
        and2.AgregarValor(not2);
        or1.AgregarValor(and1);
        or1.AgregarValor(and2);
        and3.AgregarValor(or1);
        and3.AgregarValor(c);
        
        return and3.Calcular();
    }
}