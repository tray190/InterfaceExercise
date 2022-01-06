using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Done Create 2 Interfaces called IVehicle & ICompany

            // Done Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /*Done Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Done Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Done Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Done Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            Car myFirstCar; 
            
            Car myCar = new Car();
            myCar.HasTrunk = true;
            myCar.HasFourWheels = true;
            myCar.HaveSmallBody = true;
            myCar.SteeringWheel = 1;
            myCar.Make = "nissan";
            myCar.Model = "altima";
            myCar.Logo = "nissan logo";
            myCar.Partnerships = true;
            

            var truck = new Truck();
            truck.SteeringWheel = 1;
            truck.BedSize = 5.2;
            truck.HasLongBody = true;
            truck.HasFourWheels = true;
            truck.Partnerships = true;
            truck.Logo = "truck logo";
            truck.Make = "ford";
            truck.Model = "focus";
            

            var suv = new SUV();
            suv.SteeringWheel = 1;
            suv.HasCorgoHoldTrunk = true;
            suv.HasFourWheels = true;
            suv.HasWideBody = true;
            suv.Partnerships = true;
            suv.Logo = "suv logo";
            suv.Make = "lexus";
            suv.Model = "rx300";

           
        }
    }
}
