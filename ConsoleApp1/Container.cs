using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Container
    {
        public string SerialNumber { get; set; }
        public double CargoMass { get; set; }
        public double Height { get; set; }
        public double TareWeight { get; set; }
        public double Depth { get; set; }
        public double MaxPayload { get; set; }

        public Container(string serialNumber, double cargoMass, double height, double tareWeight, double depth, double maxPayload)
        {
            SerialNumber = serialNumber;
            CargoMass = cargoMass;
            Height = height;
            TareWeight = tareWeight;
            Depth = depth;
            MaxPayload = maxPayload;
        }

        public abstract void LoadCargo(double cargoMass);
        public abstract void EmptyCargo();
    }

}
