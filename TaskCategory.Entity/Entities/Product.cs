using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TaskCategory.Core.Entities;

namespace TaskCategory.Entity.Entities
{
	[Table("Product")]
	public class Product
	{
        [Key]
        public int Id { get; set; }
		[Column("CategoryId")]
		public int CategoryId { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [Column("IsNew")]
        public bool IsNew { get; set; }
        [Column("Price")]
        public decimal Price { get; set; }
    }
}

