using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.Entities;

public class StudentTests
{
    [TestMethod]
    public void AdicionarAssinatura()
    {
        var name = new Name("Teste", "Teste");

        foreach (var not in name.Notifications)
        {
           
        }
    }
}