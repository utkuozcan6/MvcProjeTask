using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TaskCategory.Core.Entities;

namespace TaskCategory.Entity.Entities
{
    [Table("Category")]
    public class Category
	{
        [Key]
        public int Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }
    }
}

