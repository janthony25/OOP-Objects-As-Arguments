using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mustang", "red");
            // use this
            Car car2 = Copy(car1); 
            // instead of this
            // Car car2 = new Car(car.model, car.color)

            // ChangeColor(car1, "blue");

            Console.WriteLine($"{car2.color} {car2.model}");

            Console.ReadKey();
        }

        // make new copy
        public static Car Copy(Car car)
        {
            return new Car(car.model, car.color);
        }


        /*
        // change object
        public static void ChangeColor(Car cars, string color)
        {
            cars.color = color;
        }

        */
    }

    class Car
    {
        public string model;
        public string color;
        public Car(string model, string color)
        {
            this.model = model;
            this.color = color;
        }
    }
}