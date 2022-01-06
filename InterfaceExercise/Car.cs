using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public bool HasTrunk { get; set; } = true;
        public bool HaveSmallBody { get; set; } = true;
        public bool HasFourWheels { get ; set ; } = true;
        public int SteeringWheel { get; set; } = 1;
        public string Make { get ; set ; } 
        public string Model { get ; set ; }
        public string Logo { get; set; }
        public bool Partnerships { get; set; } = true;

        public void drive()
        {
            Console.WriteLine($"driving in my{GetType().Name}");

            throw new NotImplementedException();
        }
    }
}
