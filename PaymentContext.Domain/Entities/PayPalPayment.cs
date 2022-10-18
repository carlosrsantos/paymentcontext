using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities;

public class PayPalPayment : Payment
{
  public PayPalPayment(
    string transactionCode,
    DateTime paidDate,
    DateTime expireDate,
    decimal total,
    decimal totalPaid,
    string payer,
    Document document,
    Email email)
  :base(paidDate,
        expireDate,
        total,
        totalPaid,
        payer,
        document,
        email)
  {
    TransactionCode = transactionCode;
  }
  public string TransactionCode { get; set; }
}