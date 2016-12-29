using System;
using System.Collections.Generic;

namespace DressPlanner
{
	public enum ItemCategory
	{
		Tops,
		Jacket,
		Shirt,
		Pants,
		Cardigan,
		Sweater,
		Cutsew,
		Tie,
		Bottoms,
		Skirt,
		OnePiece,
		Suits,
		Other
	}

	public enum ItemBrand
	{
		None,
		Brand,
		Uniqro
	}

	public enum ItemMaterial
	{
		None,
		Cutton
	}

	public class DressItem
	{
		public int Id { get; set;}
		public string ItemName { get; set; }
		public ItemCategory Category { get; set; }
		public List<DateTime> DatesDressed;
		public List<DateTime> DatesLaunded;
		public String DressPhotoFile { get; set; } 
		public ItemLaundry Laundry { get; set; }
		public ItemBrand Brand { get; set; }
		public int PurchasePrice { get; set; }
		public ItemMaterial Material { get; set; }

		public DressItem()
		{
			DatesDressed = new List<DateTime>();
			DatesLaunded = new List<DateTime>();
		}
	}
}
