using Project0.StoreApplication.Client.Singletons;
using Xunit;
namespace Project0.StoreApplication.Testing.SingletonsTesting
{

  /// <summary>
  /// 
  /// </summary>
  public class OrderSingletonTests
  {
    [Fact]
    public void Test_OrderSingleton()
    {
      // arrange = instance of the entity to test
      var sut = OrderSingleton.Instance;

    }
  }
}