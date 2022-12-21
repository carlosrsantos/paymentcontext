using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
  [TestClass]
  public class DocumentTests
  {
    [TestMethod]
    public void ShouldReturnErrorWhenCNPJIsInvalid()
    {
      var doc = new Document("123", EDocumentType.CNPJ);
      Assert.IsTrue(!doc.IsValid);
    }

    [TestMethod]
    public void ShouldReturnSuccessWhenCNPJIsValid()
    {
      var doc = new Document("34110468000150", EDocumentType.CNPJ);
      Assert.IsTrue(doc.IsValid);
    }

    [TestMethod]
    public void ShouldReturnErrorWhenCPFIsInvalid()
    {
      var doc = new Document("345", EDocumentType.CPF);
      Assert.IsTrue(!doc.IsValid);
    }

    [TestMethod]
    public void ShouldReturnSuccessWhenCPFIsValid()
    {
      var doc = new Document("54139739347", EDocumentType.CPF);
      Assert.IsTrue(doc.IsValid);
    }

    [TestMethod]
    [DataTestMethod]
    [DataRow("34225545806")]
    [DataRow("54139739347")]
    [DataRow("01077284608")]
    public void ShouldReturnSuccessWhenCPFIsValid(string cpf)
    {
      var doc = new Document(cpf, EDocumentType.CPF);
      Assert.IsTrue(doc.IsValid);
    }
  }
}