using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.ValueObjects;

[TestClass]  
public class DocumentTests
{
    [TestMethod]
    public void ShouldReturnErrorWhenCNPJIsInvalid()
    {
        var doc = new Document("123", EDocumentType.CNPJ);
        Assert.IsTrue(doc.Invalid);
    }
    
    [TestMethod]
    public void ShouldReturnSuccessWhenCNPJIsValid()
    {
        var doc = new Document("73210195000178", EDocumentType.CNPJ);
        Assert.IsTrue(doc.Valid);
    }
    
    [TestMethod]
    public void ShouldReturnErrorWhenCPFIsInvalid()
    {
        var doc = new Document("123", EDocumentType.CPF);
        Assert.IsTrue(doc.Invalid);
    }
    
    [TestMethod]
    public void ShouldReturnSuccessWhenCPFIsValid()
    {
        var doc = new Document("96010593000", EDocumentType.CPF);
        Assert.IsTrue(doc.Valid);
    }
}