using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public string Trunk { get; set; }
        public string SmallBody { get; set; }
        public bool HasFourWheels { get ; set ; }
        public int SteeringWheel { get ; set ; }
        public string Make { get ; set ; }
        public string Model { get ; set ; }
        public string Logo { get; set; }
        public bool Partnerships { get; set; }
    }
}
