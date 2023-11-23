using System;

namespace CarRentalExercise.Domain
{
    internal class Vehicle
    {
        public string Model { get; set; }

        //Construtores
        public Vehicle()
        {
        }

        public Vehicle(string model)
        {
            Model = model;
        }
    }
}
