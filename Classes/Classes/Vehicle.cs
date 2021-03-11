using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public enum VehicleType { Car, Truck, Van, Motorcycles, Spaceships, Planes, Boats }
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public VehicleType TypeOfVehicle { get; set; }

        public bool IsRunning { get; private set; }

        public Vehicle() { }

        public Vehicle(string make, string model, double mileage, VehicleType typeOfVehicle)
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            TypeOfVehicle = typeOfVehicle;
        }

        public void TurnOn()
        {
            IsRunning = true;
            Console.WriteLine("You turn the vehicle on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("You turn off the vehicle.");
            IsRunning = false;
        }

        public Indicator RightIndicator { get; set; }
        public Indicator LeftIndicator { get; set; }

        public void IndicateRight()
        {
            RightIndicator.TurnOnFlasher();
            LeftIndicator.TurnOffFlasher();
        }

        public void IndicateLeft()
        {
            LeftIndicator.TurnOnFlasher();
            RightIndicator.TurnOffFlasher();
        }

        public void IndicateBoth()
        {
            LeftIndicator.TurnOnFlasher();
            RightIndicator.TurnOnFlasher();
        }

        public void IndicateOff()
        {
            LeftIndicator.TurnOffFlasher();
            RightIndicator.TurnOffFlasher();
        }


    }

    public class Indicator
    {
        public bool IsFlashing { get; private set; }

        public void TurnOnFlasher()
        {
            IsFlashing = true;
            Console.WriteLine("You turn the flashers on.");
        }

        public void TurnOffFlasher()
        {
            Console.WriteLine("You turn the flashers off.");
            IsFlashing = false;
        }

    }

}
