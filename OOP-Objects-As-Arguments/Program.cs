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
            People person1 = new People("Jun", 24);
            People person2 = Clone(person1);
            Console.WriteLine($"Hi {person2.name} you are {person2.age} years old");

            Computer pc = new Computer("Intel I7", "6700", "gtx 760");

            Console.WriteLine($"Jun has a {pc.proci} {pc.gen} pc that only has a {pc.gpu} as gpu");
            GpuUpgrade(pc, "3060");
            Console.WriteLine($"Jun has now upgraded his gpu to {pc.gpu}");

            Computer pc2 = newComputer(pc);
            Console.WriteLine($"Someone copied jun's computer specs and also has {pc2.proci} {pc2.gen} {pc2.gpu}");

            /* 
            
            ChangeName(person1, "Anthony");
            Console.WriteLine($"You are {person1.name} and you are {person1.age} years old");
            */

            Console.ReadKey();
        }

        // make new copy
        public static Car Copy(Car car)
        {
            return new Car(car.model, car.color);
        }

        public static People Clone(People person)
        {
            return new People(person.name, person.age);
        }

        public static Computer newComputer(Computer pc)
        {
            return new Computer(pc.proci, pc.gen, pc.gpu);
        }



        public static void GpuUpgrade(Computer pc, string gpu)
        {
            pc.gpu = gpu;
        }


        /*
        // change object
        public static void ChangeName (People person, string name)
        {
            person.name = name;
        }

        */

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

    class People
    {
        public string name;
        public int age;

        public People(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    class Computer
    {
        public string proci;
        public string gen;
        public string gpu;

        public Computer(string proci, string gen, string gpu)
        {
            this.proci = proci;
            this.gen = gen;
            this.gpu = gpu;
        }


    }
}