using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SensorData
    {
        [Key]
        public int Id { get; set; }

        public int SensorId { get; set; }

        public double? Value { get; set; }

        [Required]
        public DateTime Timestamp { get; set; }
    }
}
