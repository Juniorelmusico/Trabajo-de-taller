using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;

namespace DesignPatterns.Factories
{
    public class FordMustangFactory : CarFactory
    {
        public override Vehicle Create()
        {
            return new CarModelBuilder()
                .SetColor("yellow")
                .SetModel("Mustang")
                .SetYear(2023)
                .Build();
        }
    }
}
