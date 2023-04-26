using AngularCoreTemplate.Models;

namespace AngularCoreTemplate.Services
{
    public class HelloWorldService : IHelloWorldService
    {
        public SomethingModel DoSomething(string input)
        {
            return new SomethingModel { Id=1, Name=input };
        }

        public SomethingModel DoSomethingElse(SomethingModel input)
        {
            throw new NotImplementedException();
        }

        public List<SomethingModel> GetSomething()
        {
            List<SomethingModel> models = new List<SomethingModel>();
            models.Add(new SomethingModel { Id = 1, Name = "Test" });
            return models;
        }
    }
}
