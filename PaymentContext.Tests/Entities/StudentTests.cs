using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests;

[TestClass]
public class StudentTests
{
  [TestMethod]
  public void TestMethod1()
  {
    var student = new Student("Carlos",
      "Santos",
      "121343435",
      "hello@gmail.com");
  }
}