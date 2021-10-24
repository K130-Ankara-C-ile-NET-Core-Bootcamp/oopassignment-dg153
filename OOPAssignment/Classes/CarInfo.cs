using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPAssignment.Structs;

namespace OOPAssignment.Classes
{
    public class CarInfo
    {
        public Guid CarId { get; set; }

        public Coordinates Cordinates { get; set; }

        public CarInfo(Guid carId, Coordinates coordinates)
        {
            CarId = carId;
            Cordinates = coordinates;
        }

    }
}