using Project0.StoreApplication.Domain.Models;
using Xunit;
namespace Project0.StoreApplication.Testing.ModelsTesting
{
  public class OrderTests
  {
    [Fact]
    public void Test_Order()
    {
      // arrange = instance of the entity to test
      var sut = new Order();

      // // act = execute sut for data
      var actual = sut.ToString();

      Assert.NotNull(sut);
    }
  }
}