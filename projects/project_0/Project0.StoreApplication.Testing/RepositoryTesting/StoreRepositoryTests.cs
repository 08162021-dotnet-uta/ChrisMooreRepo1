using Xunit;
using Project0.StoreApplication.Storage;
using Project0.StoreApplication.Client.Singletons;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Testing.RepositoryTesting
{
  public class StoreRepositoryTests
  {
    [Fact]
    public void Test_StoreCollection()
    {
      // arrange = instance of the entity to test
      var sut = new StoreRepository();

      // // act = execute sut for data
      var actual = sut.Select();

      // // assert
      Assert.NotNull(actual);
    }
  }
}