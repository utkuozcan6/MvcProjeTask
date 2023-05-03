using System;
using System.Collections.Generic;
using TaskCategory.Data.Context;
using TaskCategory.Entity.Entities;

namespace TaskCategory.Models
{
	public class Repository
	{
		private static List<CategoryModel> categories = null;

		static Repository()
		{
			categories = new List<CategoryModel>()
			{
				new CategoryModel {Id = 1,Name = "Bilgisayar"},
                new CategoryModel {Id = 2,Name = "Telefon"},
                new CategoryModel {Id = 3,Name = "Tablet"},
                new CategoryModel {Id = 4,Name = "Kulaklık"},
            };
		}

		public List<CategoryModel> GetcategoryModels()
		{
			return categories;
		}
    }
}

