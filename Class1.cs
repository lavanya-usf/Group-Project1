using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project1
{
    internal class Vehicle_info
    {
        public string vehicleName;
        public string vehicleNumber;


        public Vehicle()
        {
            vehicleName = "Lamborgini";
            vehicleNumber = "369"
        }

        public Vehicle (string vehicleName,string vehicleNumber)
        {
            this.vehicleName = vehicleName;
            this.vehicleNumber = vehicleNumber;
        }



        public string getvehicleDetails()
        {
            return vehicleName;
            return vehicleNumber;
        }
    }
}
