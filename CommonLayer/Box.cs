using System.ComponentModel.DataAnnotations;

namespace CommonLayer
{
    public class Box
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
    }
}