using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace CarLotSimulator
{
    class Car
    {
        //using constructor
        public int Year;
        public string Model;
        public string Make; 
        public string Isdeliverable;
        public Car(int year, string model, string make, string deliverable)
        {
            Year = year;
            Model = model;
            Make = make;
            Isdeliverable = deliverable; 


        }
        //using method
        public void speak()
        {
            Console.WriteLine($"{Model} was made in {Year} by {Make} and is now {Isdeliverable} ");
        }

        public void EngineNoise(string noise)
        {
            string Noise = noise;
            Console.WriteLine($"Engine noise is {Noise}");
        }
        public void honkNoise(string honk)
        {
            string Honk = honk;
            Console.WriteLine($"Honk noise is {Honk}");
        }
    }
}
