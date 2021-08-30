using Project0.StoreApplication.Client.Singletons;
using Xunit;
namespace Project0.StoreApplication.Testing.SingletonsTesting
{
  /// <summary>
  /// 
  /// </summary>
  public class ProductSingletonTests
  {
    [Fact]
    public void Test_ProductSingleton()
    {
      // arrange = instance of the entity to test
      var sut = ProductSingleton.Instance;

    }
  }
}