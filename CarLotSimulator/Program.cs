using System;

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
            Carlot listofcar = new Carlot();
            Car firstcar = new Car(1992, "Ford", "Mustang", "available");
            //Car secondcar = new Car();

            //firstcar.Year = 1992;
            //firstcar.Model = "Ford";
            //firstcar.Make = "human";
            //firstcar.Isdliverable = "available";
            listofcar.AuthorList.Add(firstcar);
            //listofcar.display();
            Console.WriteLine($"{firstcar.Model} was made in {firstcar.Year} by {firstcar.Make} and it is now {firstcar.Isdeliverable}");
            //Console.WriteLine(firstcar.Model);
            Car secondcar = new Car(1992, "Ferrari", "Mustang", "available");
            listofcar.AuthorList.Add(secondcar);
            secondcar.speak();
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            Car thirdcar = new Car(1992, "Ford", "Mustang", "available");
            thirdcar.speak();
            thirdcar.EngineNoise("Loud");
            thirdcar.honkNoise("Medium");
            listofcar.display();

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            
        }
    }
}
