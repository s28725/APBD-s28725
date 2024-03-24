using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LiquidContainer : Container, IHazardNotifier
    {
        private const double MaxHazarousCargoCapacity = 0.5;
        private const double MaxOrdinaryCargoCapacity = 0.9;
        private bool isHazardous { get; set; }

        public LiquidContainer(string serialNumber, double cargoMass, double height, double tareWeight, double depth, double maxPayload, bool isHazardous)
            : base(serialNumber, cargoMass, height, tareWeight, depth, maxPayload)
        {
            this.isHazardous = isHazardous;
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

            double maxCapacity = MaxOrdinaryCargoCapacity;
            if (isHazardous)
            {
                maxCapacity = MaxHazarousCargoCapacity;
            }

            if (CargoMass + cargoMass > MaxPayload * maxCapacity)
            {
                throw new DangerousLoadException("Loading dangerous mass beyond capacity is prohibited");
            }

            CargoMass += cargoMass;
        }

        public override void EmptyCargo()
        {
            CargoMass = 0;
        }

        public override string ToString()
        {
            return $"Liquid Container, Serial Number: {SerialNumber}, Cargo Mass: {CargoMass}, Height: {Height}, Tare Weight: {TareWeight}, Depth: {Depth}, Max Payload: {MaxPayload}, Is Hazardous: {isHazardous}";
        }
    }
}
