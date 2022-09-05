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

        [Required]
        [Column(TypeName = "varchar(150)")]
        [MaxLength(200)]
        [Display(Name = "Name")]
        public string ProductName { get; set; }

        [Required]
        [Column(TypeName = "varchar(150)")]
        [MaxLength(200)]
        [Display(Name = "Size")]
        public string ProductSize { get; set; }

        [Required]
        [Column(TypeName = "varchar(150)")]
        [MaxLength(200)]
        [Display(Name = "Price")]
        public string ProductPrice { get; set; }

        [Display (Name ="Photo")]
        public string ProductPhoto { get; set; }

        [ForeignKey("Item")]
        [Required]
        public int ItemID { get; set; }

        [Display(Name = "Item")]
        [NotMapped]
        public string ItemName { get; set; }


        public virtual Item Item { get; set; }
    }
}
