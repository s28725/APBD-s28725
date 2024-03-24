using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RefrigeratedContainer : Container
    {
        public double ContainerTemperature { get; set; }
        public string ProductType { get; set; }

        public RefrigeratedContainer(string serialNumber, double cargoMass, double height, double tareWeight, double depth, double maxPayload, string productType, double containerTemperature)
            : base(serialNumber, cargoMass, height, tareWeight, depth, maxPayload)
        {
            ProductType = productType;
            ContainerTemperature = containerTemperature;
        }

        public override void EmptyCargo()
        {
            CargoMass = 0;
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

        public override string ToString()
        {
            return $"Refrigerated container, Serial Number: {SerialNumber}, Cargo Mass: {CargoMass}, Height: {Height}, Tare Weight: {TareWeight}, Depth: {Depth}, Max Payload: {MaxPayload}, Product Type: {ProductType}, Container Temperature: {ContainerTemperature}";
        }
    }
}
