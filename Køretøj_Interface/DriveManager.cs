using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køretøj_Interface
{
    public static class DriveManager
    {
        public static void StartAllVehicles(List<IDriveable> vehicles)
        {
            foreach (var vehicle in vehicles)
            {
                vehicle.Start();
            }
        }
    }
}
