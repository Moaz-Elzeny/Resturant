using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Models
{
    [Table("Product", Schema ="dto")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name ="Product ID")]
        public int ProductID { get; set; }

        [ForeignKey("Item")]
        [Required]
        public int ItemID { get; set; }

        [Display(Name = "Item")]
        [NotMapped]
        public string ItemName { get; set; }


        public virtual Item Item { get; set; }
    }
}
