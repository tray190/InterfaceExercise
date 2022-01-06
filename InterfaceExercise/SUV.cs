using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany 
    {
        public bool HasCorgoHoldTrunk { get; set; } = true;
        public bool HasWideBody { get; set; } = true;
        public bool HasFourWheels { get ; set ; } = true;
        public int SteeringWheel { get ; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Logo { get; set; }
        public bool Partnerships { get; set; }

        public void drive()
        {
            throw new NotImplementedException();
        }
    }
}
