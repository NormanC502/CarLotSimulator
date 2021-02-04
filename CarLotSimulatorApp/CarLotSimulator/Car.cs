using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
        }

        public string Make { get; set; }
        public string Model { get; set; }
        
        public int Year { get; set; }

        public string EngineNoise { get; set; }

        public string HonkNoise { get; set; }

        public bool IsDriveable { get; set;  }

        public Car(string make, string model, int year, string engineNoise, string honkNoise, bool isDriveable) 
        {
            Make =              make;
            Model =             model;
            Year =              year;
            EngineNoise =       engineNoise;
            HonkNoise =         honkNoise;
            IsDriveable =       isDriveable;

        }

        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine($"The engine {engineNoise}!\n");
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine($"The horn makes this sound {honkNoise}!\n");
        }              
    }
}