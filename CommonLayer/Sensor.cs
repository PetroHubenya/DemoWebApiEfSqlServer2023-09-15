using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer
{
    public class Sensor
    {
        [Key]
        public int Id { get; set; }

        public int? BoxId { get; set; }

        [Required]
        public TypeOfSensor Type { get; set; }        
    }
}
