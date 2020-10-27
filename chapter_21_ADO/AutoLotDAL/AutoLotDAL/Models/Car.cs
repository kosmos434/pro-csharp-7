using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLotDAL.Models
{
    // these types of classes are called models
    // they represent and transport data from the database
    // so this will represent one row from the car inventory table
    public class Car
    {
        public int CarId { get; set; }
        public string Color { get; set; }
        public string Make { get; set; }
        public string PetName { get; set; }
    }
}
