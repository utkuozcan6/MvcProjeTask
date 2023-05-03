using System;
namespace TaskCategory.Models
{
	public class ProductModel
	{
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string Name { get; set; }

        public bool IsNew { get; set; }

        public decimal Price { get; set; }
    }
}

