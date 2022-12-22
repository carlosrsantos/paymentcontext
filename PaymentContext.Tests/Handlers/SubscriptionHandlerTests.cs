using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests;

[TestClass]

public class SubscriptionHandlerTests
{
  [TestMethod]
  public void ShouldReturnErrorWhenDocumentExists()  
  {
    var handler = new SubscriptionHandler(new FakeStudentRepository());
    var command = new CreateBoletoSubscriptionCommand();
    command.FirstName = "Elliot";
    command.LastName = "Alderson";
    command.Document = "999999999999";
    command.Email = "teste@mail.com";
    command.BarCode = "909090909";
    command.BoletoNumber = "00001";
    command.PaymentNumber = "4321" ;
    command.PaidDate = DateTime.Now;
    command.ExpireDate = DateTime.Now.AddMonths(1);
    command.Total = 60;
    command.TotalPaid = 60;
    command.Payer = "Allsafe Cybersecurity";
    command.PayerDocument = "123456789" ;
    command.PayerDocumentType = EDocumentType.CPF;
    command.PayerEmail = "elliot.alderson@allsafe.com";
    command.Street = "Some";
    command.Number = "000";
    command.Neighborhood = "Inexists";
    command.City = "Boom";
    command.State = "BM";
    command.Country = "EUA";
    command.ZipCode = "ac121";

    handler.Handle(command);
    Assert.AreEqual(false, handler.IsValid);

  }
}