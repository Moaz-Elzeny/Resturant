using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Models
{
    [Table("Order",Schema ="dto")]
    public class Order
    { 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name ="Order Id")]
        public int OrderId { get; set; }

        [Required]
        [Column(TypeName ="varchar(150)")]
        [MaxLength(200)]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

        [Required]
        [Column(TypeName ="varchar(20)")]
        [MaxLength(20)]
        [Display(Name = "Customer Phone")]
        public string CustomerPhone { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        [MaxLength(10)]
        [Display(Name = "Order Amount")]
        public string OrderAmount { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Order Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MMMM-yyyy}")]
        public DateTime OrderDate { get; set; }

        public int MyProperty { get; set; }

        [ForeignKey("Item")]
        [Required]
        public int ItemID { get; set; }

        [Display(Name = "Item")]
        [NotMapped]
        public string ItemName { get; set; }


        public virtual Item Item { get; set; }
    }
}
