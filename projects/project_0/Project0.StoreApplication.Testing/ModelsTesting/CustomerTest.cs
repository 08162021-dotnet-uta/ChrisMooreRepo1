using Project0.StoreApplication.Domain.Models;
using Xunit;
namespace Project0.StoreApplication.Testing.ModelsTesting
{
  public class CustomerTests
  {
    [Fact]
    public void Test_Customer()
    {
      // arrange = instance of the entity to test
      var sut = new Customer();

      // // act = execute sut for data
      var actual = sut.ToString();
    }
  }
}