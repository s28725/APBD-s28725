using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GasContainer : Container, IHazardNotifier
    {
        private const double UnloadingConeficient = 0.05;
        public double Pressure { get; set; }

        public GasContainer(string serialNumber, double cargoMass, double height, double tareWeight, double depth, double maxPayload, double pressure)
            : base(serialNumber, cargoMass, height, tareWeight, depth, maxPayload)
        {
            Pressure = pressure;
        }

        public void HazardHappened(string containerNumber)
        {
            Console.WriteLine($"Hazardous situation was noticed at container {containerNumber}");
        }

        public override void LoadCargo(double cargoMass)
        {
            if (cargoMass > MaxPayload)
            {
                throw new OverfillException("Cargo exceeded the max payload");
            }

            if (CargoMass + cargoMass > MaxPayload)
            {
                throw new DangerousLoadException("Loading dangerous mass beyond capacity is prohibited");
            }

            CargoMass += cargoMass;
        }

        public override void EmptyCargo()
        {
            CargoMass = CargoMass - (CargoMass * UnloadingConeficient);
        }

        public override string ToString()
        {
            return $"Gas container, Serial Number: {SerialNumber}, Cargo Mass: {CargoMass}, Height: {Height}, Tare Weight: {TareWeight}, Depth: {Depth}, Max Payload: {MaxPayload}, Pressure: {Pressure}";
        }
    }
}
