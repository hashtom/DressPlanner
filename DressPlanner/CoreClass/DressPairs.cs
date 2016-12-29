using System;
using System.Collections.Generic;

namespace DressPlanner
{
	public class DressPairs
	{
		public DateTime DressDate { get; set; }
		public List<DressItem> DressItems;

		public DressPairs()
		{
			DressItems = new List<DressItem>();
		}
	}
}
