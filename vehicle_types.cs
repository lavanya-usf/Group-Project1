using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project1
{
    internal class VehicleTypes
    {
        public string vehicleType;
        public string vehicleCondition;
        public static string insuranceNumber = "ffsh";
        public string insurance;

        public VehicleTypes()
        {
            vehicleType = "2-wheeler";
            vehicleCondition = string.Empty;
            insurance = insuranceNumber;
        }

        public string getVehicleType()
        {
            return vehicleType + " " + vehicleCondition;
        }

        public void setVehicleType(string VehicleType, String VehicleCondition, string Insurance)
        {
            this.vehicleType = VehicleType;
            this.vehicleCondition = VehicleCondition;
            this.insurance = Insurance;
        }

    }
}
    
