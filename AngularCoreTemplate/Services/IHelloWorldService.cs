using AngularCoreTemplate.Models;

namespace AngularCoreTemplate.Services
{
    public interface IHelloWorldService
    {
        List<SomethingModel> GetSomething();

        SomethingModel DoSomething(string input);

        SomethingModel DoSomethingElse(SomethingModel input);
    }
}
