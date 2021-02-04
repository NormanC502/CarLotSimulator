using System;
using System.Collections.Concurrent;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            //Creat and object
            var carsOnLot = new CarLot();

            var carLotsCar1 = new Car()
            {
                Make =          "Ford",
                Model =         "Mustang GT",
                Year =          2021,
                EngineNoise =   "Loud",
                HonkNoise =     "Dukes of Hazard",
                IsDriveable =   true,                
            };

            carsOnLot.Cars.Add(carLotsCar1);


                

            Car carLotsCar2 = new Car();

            carLotsCar2.Make =              "Honda";
            carLotsCar2.Model =             "Accord";
            carLotsCar2.Year =               2021;
            carLotsCar2.EngineNoise =       "Loud";
            carLotsCar2.HonkNoise =         "Beep";
            carLotsCar2.IsDriveable =        true;

            carsOnLot.Cars.Add(carLotsCar2);


            

            Car carLotsCar3 = new Car("Dodge", "Charger SRT", 2021, "Lions Roar", "Get Over Here!", true);

             carsOnLot.Cars.Add(carLotsCar3);


            Car carLotsCar4 = new Car();

            carLotsCar4.Make = "Mercedes";
            carLotsCar4.Model = "Benz";
            carLotsCar4.Year = 2021;
            carLotsCar4.EngineNoise = "Quiet";
            carLotsCar4.HonkNoise = "Mozart";
            carLotsCar4.IsDriveable = true;

            carsOnLot.Cars.Add(carLotsCar4);



            carLotsCar1.MakeEngineNoise(carLotsCar1.EngineNoise);

            carLotsCar2.MakeEngineNoise(carLotsCar2.EngineNoise);

            carLotsCar3.MakeEngineNoise(carLotsCar3.EngineNoise);

            carLotsCar4.MakeEngineNoise(carLotsCar4.EngineNoise);





            carLotsCar1.MakeHonkNoise(carLotsCar1.HonkNoise);

            carLotsCar2.MakeHonkNoise(carLotsCar2.HonkNoise);

            carLotsCar3.MakeHonkNoise(carLotsCar3.HonkNoise);

            carLotsCar4.MakeHonkNoise(carLotsCar4.HonkNoise);



            foreach (var vehicle in carsOnLot.Cars) 
            {
                Console.WriteLine($"Car Year: {vehicle.Year}            Make: {vehicle.Make}               Model. {vehicle.Model }\n");
            } 

        }
    }
}
