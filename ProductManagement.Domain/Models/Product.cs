using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Domain.Models
{
    public class Product:BaseModel
    {
        public string Name { get; set; }

        public int NumberOfUnitsAvailable { get; set; }

        public int ReOrderLevel { get; set; }

        public decimal UnitPrice { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

    }
}
