using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarLotSimulator
{
    class Carlot
    {
        public List<Car> AuthorList = new List<Car>();
        public void display()
        {
            foreach (var author in AuthorList)
            {

                Console.WriteLine("Car details: {0}, {1}, {2}, {3}", author.Model, author.Year, author.Make, author.Isdeliverable);
         
            }
        }
}
}
