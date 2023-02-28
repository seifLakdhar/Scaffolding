using System.ComponentModel.DataAnnotations;

namespace Scaffold.Model
{
    public class Product
    {
        [Key]
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
       


    }
}
