using Project0.StoreApplication.Client.Singletons;
using Xunit;
namespace Project0.StoreApplication.Testing.SingletonsTesting
{
  public class StoreSingletonTests
  {
    [Fact]
    public void Test_StoreSingleton()
    {
      // arrange = instance of the entity to test
      var sut = StoreSingleton.Instance;
    }
  }
}