using Project0.StoreApplication.Domain.Models;
using Xunit;
namespace Project0.StoreApplication.Testing.ModelsTesting
{
  public class StoreTests
  {
    [Fact]
    public void Test_Store()
    {
      // arrange = instance of the entity to test
      var sut = new Store();

      // // act = execute sut for data
      var actual = sut.ToString();
    }
  }
}