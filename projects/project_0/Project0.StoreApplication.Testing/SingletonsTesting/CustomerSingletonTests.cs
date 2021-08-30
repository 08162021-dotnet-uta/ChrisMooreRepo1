using Project0.StoreApplication.Client.Singletons;
using Xunit;
namespace Project0.StoreApplication.Testing.SingletonsTesting
{
  /// <summary>
  /// 
  /// </summary>
  public class CustomerSingletonTests
  {
    [Fact]
    public void Test_CustomerSingleton()
    {
      // arrange = instance of the entity to test
      var sut = CustomerSingleton.Instance;

    }
  }
}