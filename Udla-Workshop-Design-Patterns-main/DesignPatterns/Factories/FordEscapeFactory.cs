using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;

namespace DesignPatterns.Factories
{
    public class FordEscapeFactory : CarFactory
    {
        public override Vehicle Create()
        {
            return new CarModelBuilder()
                .SetColor("red")
                .SetModel("Escape")
                .SetYear(2023)
                .Build();
        }
    }
}
