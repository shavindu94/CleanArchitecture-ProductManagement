using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Application.ViewModels
{
    public class EditProductViewModel
    {

        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int NumberOfUnitsAvailable { get; set; }

        [Required]
        public int ReOrderLevel { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }


        public string CraeatedBy { get; set; }
    }
}
