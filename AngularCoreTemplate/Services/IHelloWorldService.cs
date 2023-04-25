using AngularCoreTemplate.Models;

namespace AngularCoreTemplate.Services
{
    public interface IHelloWorldService
    {
        SomethingModel DoSomething(string input);

        SomethingModel DoSomethingElse(SomethingModel input);
    }
}
