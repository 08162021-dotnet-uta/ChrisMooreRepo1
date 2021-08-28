using Project0.StoreApplication.Domain.Models;
using Xunit;
namespace Project0.StoreApplication.Testing.ModelsTesting
{
  public class ProductTests
  {
    [Fact]
    public void Test_Product()
    {
      // arrange = instance of the entity to test
      var sut = new Product();

      // // act = execute sut for data
      var actual = sut.ToString();
    }
  }
}