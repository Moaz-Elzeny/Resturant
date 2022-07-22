﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Models
{
    [Table("Item", Schema ="dto")]
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Item Id")]
        public int ItemID { get; set; }

        [Required]
        [Column(TypeName = "varchar(150)")]
        [MaxLength(200)]
        [Display(Name = "Name")]
        public string ItemName { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [MaxLength(20)]
        [Display(Name = "Price")]
        public string ItemPrice { get; set; }

        [Required]
        [Column(TypeName = "varchar(150)")]
        [MaxLength(100)]
        [Display(Name = "Size")]
        public string Size { get; set; }

        [Display(Name ="Photo")]
        public byte[] ItemPhoto { get; set; }
    }
}
