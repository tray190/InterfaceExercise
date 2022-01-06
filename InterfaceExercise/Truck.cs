using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public double BedSize { get; set; }
        public bool HasLongBody { get; set; }
        public bool HasFourWheels { get ; set ; }
        public int SteeringWheel { get ; set ; }
        public string Make { get ; set; }
        public string Model { get; set; }
        public string Logo { get; set; }
        public bool Partnerships { get; set; }

        public void drive()
        {
            throw new NotImplementedException();
        }
    }
}
