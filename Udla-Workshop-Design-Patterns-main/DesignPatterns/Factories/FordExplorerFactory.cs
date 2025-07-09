using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;

namespace DesignPatterns.Factories
{
    public class FordExplorerFactory : CarFactory
    {
        public override Vehicle Create()
        {
            return new CarModelBuilder()
                .SetColor("blue")
                .SetModel("Explorer")
                .SetYear(2023)
                .Build();
        }
    }
}
