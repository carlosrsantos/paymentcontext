using PaymentContext.Domain.Commands;

namespace PaymentContext.Tests;

[TestClass]
public class CreateBoletoSubscriptionCommandTests
{
  [TestMethod]
  public void ShouldReturnErrosWhenNameIsInvalid()
  {
    var command = new CreateBoletoSubscriptionCommand();
    command.FirstName = "";

    command.Validate();
    Assert.AreEqual(false, command.IsValid);
  }

  [TestMethod]
  public void ShouldReturnSuccessWhenNameIsValid()
  {
    var command = new CreateBoletoSubscriptionCommand();
    command.FirstName = "Jhon";

    command.Validate();
    Assert.IsTrue(command.IsValid);
  }
}