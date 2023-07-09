using System;

namespace DesignPatterns.Models
{
    public class CarBuilder
    {
        public string Brand = "Ford";
        public string Model = "Mustang";
        public string Color = "Red";
        public int Year = DateTime.Now.Year;

        public int Property1 = 10;
        public string Property2 = "Example";

        public CarBuilder SetBrand(string brand) {
            Brand = brand;
            return this;
        }
        public CarBuilder SetModel(string model)
        {
            Model = model;
            return this;
        }

        public CarBuilder SetColor(string color)
        {
            Color = color;
            return this;
        }

        public CarBuilder SetYear(int year)
        {
            Year = year;
            return this;
        }

        // Agrega los métodos para establecer las propiedades adicionales por defecto según sea necesario
        public CarBuilder SetProperty1(int value)
        {
            // Establece la propiedad adicional 1 por defecto
            Property1 = value;
            return this;
        }

        public CarBuilder SetProperty2(string value)
        {
            // Establece la propiedad adicional 2 por defecto
            Property2 = value;
            return this;
        }

        // ... Agrega los métodos para establecer las demás propiedades adicionales según sea necesario

        public Car Build()
        {
            return new Car(Color, Brand, Model, Year)
            {
                // Asigna las propiedades adicionales al objeto Car
                Property1 = Property1,
                Property2 = Property2,
                // ... Asigna las demás propiedades adicionales según sea necesario
            }; 
        }
    }
}
