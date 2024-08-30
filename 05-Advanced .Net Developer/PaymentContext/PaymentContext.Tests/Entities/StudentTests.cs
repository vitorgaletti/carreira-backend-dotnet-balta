using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests.Entities;

public class StudentTests
{
    [TestMethod]
    public void AdicionarAssinatura()
    {
        var subcription = new Subscription(null);
        var student = new Student("André", "Baltieri", "12345678912", "hello@balta.io");
        student.AddSubscription(subcription);
    }
}