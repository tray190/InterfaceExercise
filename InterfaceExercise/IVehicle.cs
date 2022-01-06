using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public bool HasFourWheels { get; set; }
        public int SteeringWheel { get; set;  }
        public string Make { get; set; }
        public string Model { get; set; }

        void drive();
    }
}
