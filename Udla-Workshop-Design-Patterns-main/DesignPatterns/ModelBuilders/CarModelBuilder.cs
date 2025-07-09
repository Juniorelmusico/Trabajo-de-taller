using DesignPatterns.Models;
using Microsoft.VisualBasic;

namespace DesignPatterns.ModelBuilders
{
    public class CarModelBuilder
    {
        private string color = "red";
        private string brand = "Ford";
        private string model = "Mustang";
        private int year = DateAndTime.Now.Year;

        public CarModelBuilder SetColor(string color)
        {
            this.color = color;
            return this;
        }

        public CarModelBuilder SetBrand(string brand)
        {
            this.brand = brand;
            return this;
        }

        public CarModelBuilder SetModel(string model)
        {
            this.model = model;
            return this;
        }

        public CarModelBuilder SetYear(int year)
        {
            this.year = year;
            return this;
        }

        public Car Build()
        {
            return new Car(color, brand, model, year);
        }

    }
}
