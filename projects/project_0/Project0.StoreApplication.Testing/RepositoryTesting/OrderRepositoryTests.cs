using Project0.StoreApplication.Storage.Repositories;
using Xunit;
namespace Project0.StoreApplication.Testing.RepositoryTesting
{
  public class OrderRepositoryTests
  {
    [Fact]
    public void Test_OrderCollection()
    {
      // arrange = instance of the entity to test
      var sut = new OrderRepository();

      // // act = execute sut for data
      var actual = sut.Select();

      // // assert
      Assert.NotNull(actual);
    }
  }
}