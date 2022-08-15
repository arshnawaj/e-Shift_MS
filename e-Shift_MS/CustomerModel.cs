using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Shift_MS
{
    class CustomerModel
    {
        [Required]
        [DataType(DataType.PhoneNumber)]

        public int Contact { get; set; }
    }
}
